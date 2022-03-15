using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class CreateCoursPrevu : Form
    {
        //long _ecoleId;
        //long _anneeScolaireId;
        long _salleClasseId;
        string _userName;
        public List<CoursPrevu> _listCoursPrevuCreated = new List<CoursPrevu>();
        public CreateCoursPrevu(long salleClasseId, string userName)
        {
            //_ecoleId = ecoleId;
            //_anneeScolaireId = anneeScolaireId;
            _salleClasseId = salleClasseId;
            _userName = userName;

            InitializeComponent();

            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);
            cbMatiere.Items.Add("Choisissez la matière");
            cbMatiere.SelectedIndex = 0;
            cbEnseignant.Items.Add("Choisissez l'enseignant");
            cbEnseignant.SelectedIndex = 0;
            cbJour.Items.Add("Choisissez le jour");

            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.CustomFormat = "HH:mm:ss tt";
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.CustomFormat = "HH:mm:ss tt";
            dtpEndTime.ShowUpDown = true;

            EcoleFactory Factory = new EcoleFactory();
            SalleClasse salleClasse = Factory.getSalleClasseById(_salleClasseId);
            lblSalleClasse.Text = salleClasse.ToString();
            AnneeScolaire anneeScolaire = salleClasse.AnneeScolaire;
            dtpStartDate.MinDate = anneeScolaire.StartDate;
            dtpStartDate.MaxDate = anneeScolaire.EndDate;

            LoadJours();
            LoadMatieres();

        }

        private void LoadJours()
        {
            Array jours = Enum.GetValues(typeof(Jour));
            foreach (Jour jour in jours)
            {
                cbJour.Items.Add(jour);
            }
            cbJour.SelectedIndex = 0;
        }
        private void LoadMatieres()
        {
            cbMatiere.DataSource = null;

                EnseignementFactory Factory = new EnseignementFactory();
                List<Matiere> ListMatieres = Factory.getSalleClasseMatiere(_salleClasseId).Select(sc => sc.Matiere)
                    .Distinct().OrderBy(m => m.Name).ToList();
                if (ListMatieres.Count > 0)
                    foreach (Matiere m in ListMatieres)
                        cbMatiere.Items.Add(m);

        }

        private void LoadEnseignants()
        {
            cbEnseignant.DataSource = null;
            if (cbMatiere.SelectedIndex > 0 )
            {
                EnseignementFactory Factory = new EnseignementFactory();
                long matiereId = ((Matiere)cbMatiere.SelectedItem).Id;
                List<Enseignant> ListEnseignants = Factory.getListEnseignantForSalleClasseAndMatiere(_salleClasseId, matiereId)
                    .OrderBy(ens => ens.LastName).ToList();
                if (ListEnseignants.Count > 0)
                    foreach (Enseignant ens in ListEnseignants)
                        cbEnseignant.Items.Add(ens);
                cbEnseignant.SelectedIndex = 0;
            }
        }

        private void SaveRecord()
        {
            if (cbMatiere.SelectedIndex > 0 &&
                cbJour.SelectedIndex > 0 && cbEnseignant.SelectedIndex > 0)
            {
                int StartYear = dtpStartDate.Value.Year;
                int StartMonth = dtpStartDate.Value.Month;
                int StartDay = dtpStartDate.Value.Day;
                int StartHour = dtpStartTime.Value.Hour;
                int StartMin = dtpStartTime.Value.Minute;
                int StartSec = dtpStartTime.Value.Second;

                int EndYear = dtpEndDate.Value.Year;
                int EndMonth = dtpEndDate.Value.Month;
                int EndDay = dtpEndDate.Value.Day;
                int EndHour = dtpEndTime.Value.Hour;
                int EndMin = dtpEndTime.Value.Minute;
                int EndSec = dtpEndTime.Value.Second;

                if ( (dtpEndDate.Value.Date <= dtpStartDate.Value.Date) ||
                     ( (EndHour*60 + EndMin) <= (StartHour*60 + StartMin) ) )
                {
                    MessageBox.Show("Date de début supérieure à la date de fin");
                }
                else
                {
                    // Search for conflicts in scheduling
                    
                    DateTime startStartDate = new DateTime(StartYear, StartMonth, StartDay, StartHour, StartMin, StartSec);
                    DateTime endStartDate = new DateTime(StartYear, StartMonth, StartDay, EndHour, EndMin, EndSec);

                    DateTime startEndDate = new DateTime(EndYear, EndMonth, EndDay, StartHour, StartMin, StartSec);
                    DateTime endEndDate = new DateTime(EndYear, EndMonth, EndDay, EndHour, EndMin, EndSec);

                    Jour jour = (Jour)cbJour.SelectedItem;
                    EnseignementFactory Factory = new EnseignementFactory();
                    List<CoursPrevu> ListCoursPrevus = Factory.getAllCourPrevusBetweenDates(_salleClasseId, jour, startStartDate, endStartDate, startEndDate, endEndDate);

                    if (ListCoursPrevus.Count > 0)
                    {
                        //There are conflicts
                        StringBuilder conflicts = new StringBuilder("List des conflits");
                        foreach (CoursPrevu cp in ListCoursPrevus)
                        {
                            conflicts.Append("\n");
                            conflicts.Append("Cours prévu : " + cp.PortfolioEnseignant.SalleClasseMatiere.Matiere.Name + "\n");
                            conflicts.Append("Date prévu : " + cp.Start.Date.ToShortDateString() + "\n");
                            conflicts.Append("Temps prévu : " + cp.Start.Hour.ToString() + ":" + cp.Start.Minute.ToString() + " à ");
                            conflicts.Append(cp.End.Hour.ToString() + ":" + cp.End.Minute.ToString() + "\n");
                        }
                        MessageBox.Show("Il y'a des conflits avec les horaires");
                    }
                    else
                    {
                        //No conflicts: Save Them
                        Matiere matiere = (Matiere)cbMatiere.SelectedItem;
                        Enseignant enseignant = (Enseignant)cbEnseignant.SelectedItem;
                        PortfolioEnseignant pfe = Factory.getPortfolioEnseignantMatiereSalleClasse(matiere.Id, _salleClasseId, enseignant.Id);

                        DateTimeFactory dtFactory = new DateTimeFactory();
                        DateTime firstDate = dtFactory.getFirstDateFromDateAndJour(startStartDate, jour);
                        startStartDate = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, startStartDate.Hour, startStartDate.Minute, startStartDate.Second);
                        endStartDate = new DateTime(firstDate.Year, firstDate.Month, firstDate.Day, endStartDate.Hour, endStartDate.Minute, endStartDate.Second);

                        _listCoursPrevuCreated.AddRange(Factory.createCoursPrevuBetweenDates(pfe.Id, startStartDate, endStartDate, startEndDate, endEndDate, _userName.ToUpper(), DateTime.Now));
                    }

                }
            }
            else
            {
                MessageBox.Show("Matiere/Enseignant/Jour Manquant(s)");
            }
        }
        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            //SaveRecord();
            //tbLastName.Text = null;
            //tbFirstName.Text = null;
            //tbOtherNames.Text = null;
            //pbEleve.Image = null;
            //dtpDOB.Value = DateTime.Today;
            //cbSexe.SelectedIndex = 0;
            //tbNotes.Text = null;
            //tbNotes.Text = null;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMatiere.SelectedIndex > 0)
            {
                LoadEnseignants();
            }
        }
    }
}
