using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class CreatePortfolioEnseignant : Form
    {
        long _ecoleId;
        long _anneeScolaireId;
        long _enseignantId;
        string _userName;
        public CreatePortfolioEnseignant(long ecoleId, long anneeScolaireId, long enseignantId, string userName)
        {
            _ecoleId = ecoleId;
            _anneeScolaireId = anneeScolaireId;
            _enseignantId = enseignantId;
            _userName = userName;
            InitializeComponent();
            LoadMatieres();
           
            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);

            // Fill the Enseignant Label
            EnseignementFactory Factory = new EnseignementFactory();
            lblEnseignant.Text = Factory.getEnseignantById(_enseignantId).ToString();

            LoadDatePickers();
        }


        private void LoadDatePickers()
        {
            EcoleFactory Factory = new EcoleFactory();
            AnneeScolaire anneeScolaire = Factory.getAnneeScolaireById(_anneeScolaireId);
            dtpStart.MinDate = anneeScolaire.StartDate;
            dtpStart.MaxDate = anneeScolaire.EndDate;
            dtpEnd.MinDate = anneeScolaire.StartDate;
            dtpEnd.MaxDate = anneeScolaire.EndDate;
            dtpStart.Value = anneeScolaire.StartDate;
            dtpEnd.Value = anneeScolaire.EndDate;
        }

        private void LoadMatieres()
        {
            cbMatieres.Items.Clear();
            cbMatieres.Items.Add("Choisissez une matière");
            EnseignementFactory Factory = new EnseignementFactory();
            List<Matiere> ListMatieres = Factory.getAllMatieres();
            if (ListMatieres.Count > 0)
                foreach (Matiere mat in ListMatieres)
                    cbMatieres.Items.Add(mat);
            cbMatieres.SelectedIndex = 0;
        }

        private void LoadSalleClasses(long matiereId)
        {
            cbSalleClasses.Items.Clear();
            cbSalleClasses.Items.Add("Choisissez une classe");
            EnseignementFactory Factory = new EnseignementFactory();
            List<SalleClasse> ListSalleClasses = Factory.getSalleClassesFromMatiere(matiereId, _anneeScolaireId);
            if (ListSalleClasses.Count > 0)
                foreach (SalleClasse sc in ListSalleClasses)
                    cbSalleClasses.Items.Add(sc);
            cbSalleClasses.SelectedIndex = 0;

        }
        private void cbMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMatieres.SelectedIndex > 0)
            {
                long matiereId = ((Matiere)cbMatieres.SelectedItem).Id;
                LoadSalleClasses(matiereId);
            }
        }


        private void SaveRecord()
        {
            if (DateTime.Compare(dtpStart.Value, dtpEnd.Value) > 0)
            {
                MessageBox.Show("La date de fin doit etre supérieure  à la da de début");
            }
            else
            {
                EnseignementFactory Factory = new EnseignementFactory();
                if (cbMatieres.SelectedIndex> 0 && cbSalleClasses.SelectedIndex > 0)
                {
                    long matiereId = ((Matiere)cbMatieres.SelectedItem).Id;
                    long salleClasseId = ((SalleClasse)cbSalleClasses.SelectedItem).Id;
                    PortfolioEnseignant pfe = Factory.getPortfolioEnseignantMatiereSalleClasse(matiereId, salleClasseId, _enseignantId);
                    if (pfe != null)
                    {
                        MessageBox.Show("L'enseignant a déjà été assigné a la matière pour cette classe");
                    }
                    else
                    {
                        //Save Record
                        SalleClasseMatiere scm = Factory.getSalleClasseMatiereFromSalleClasseAndMatiere(salleClasseId, matiereId);
                        long pfeId = Factory.createPortfolioEnseignant(scm.Id, _enseignantId, dtpStart.Value, dtpEnd.Value, tbNotes.Text.Trim(), 
                            _userName, DateTime.Now);
                    }
                }
                else
                {
                    MessageBox.Show("Matiere et/ou classe manquante(s)");
                }
            }
        }

        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            SaveRecord();
            LoadMatieres();
            LoadSalleClasses(0);
            LoadDatePickers();
            tbNotes.Text = null;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
