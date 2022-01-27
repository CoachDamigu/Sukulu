using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class EcoleActions : UserControl
    {
        long _ecoleId, _anneeScolaireId;
        string _userName;
        public EcoleActions(long ecoleId, long anneeScolaireId, string userName)
        {
            InitializeComponent();
            _ecoleId = ecoleId;
            _anneeScolaireId = anneeScolaireId;
            _userName = userName;
            AddControls();
            LoadSalleClasses();
            // initialize de SalleClasse combo box
            LoadSalleClassesComobBox();

        }

        private void LoadSalleClassesComobBox()
        {
            cbClasses.Items.Clear();
            cbClasses.Items.Add("Choisissez une classe");
            cbClasses.Items.Add("Toutes les classes");
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> AllSalleClasses = Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId).OrderBy(sc => sc.Classe.Niveau.Ranking)
                .ThenBy(sc => sc.Code).ToList();
            if (AllSalleClasses.Count > 0)
                foreach (SalleClasse sc in AllSalleClasses)
                    cbClasses.Items.Add(sc);
            cbClasses.SelectedIndex = 0;
        }

        public void AddControls()
        {
            //Add a header
            EcoleFactory Factory = new EcoleFactory();
            Ecole ecole = Factory.getEcoleById(_ecoleId);
            Header header = new Header(ecole.FullName + " (Inscriptions, Elèves, Classes)");
            header.CloseClicked += new EventHandler(CloseControlClicked);
            header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(header);

            //Add a footer
            AddDeleteViewUpdateReportPrint footer = new AddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
            footer.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(footer);

            footer.btnDelete.Visible = false;
            footer.btnPrint.Visible = false;
            footer.btnReport.Visible = false;

            footer.AddClicked += new EventHandler(AddRecordClicked);
            footer.DeleteClicked += new EventHandler(DeleteRecordClicked);
            footer.UpdateClicked += new EventHandler(UpdateRecordClicked);
            footer.ViewClicked += new EventHandler(ViewRecordClicked);
            footer.ReportClicked += new EventHandler(GenerateReportClicked);
            footer.PrintClicked += new EventHandler(PrintRecordsClicked);
        }

        private void LoadSalleClasses()
        {
            dgvSalleClasses.DataSource = null;
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> AllSalleClasses= Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId).OrderBy(sc => sc.Classe.Niveau.Ranking)
                .ThenBy(sc => sc.Code).ToList();
            if (AllSalleClasses.Count > 0)
            {
                var source = new BindingSource();
                var ListSalleClasses = from sc in AllSalleClasses
                                       select new
                                       {
                                           Id = sc.Id,
                                           Code = sc.Code,
                                           Name = sc.Name
                                       };
                dgvSalleClasses.AutoGenerateColumns = true;
                source.DataSource = ListSalleClasses;
                dgvSalleClasses.DataSource = source;
                dgvSalleClasses.Columns[0].Visible = false;
            }
        }

        private void LoadEleves(Boolean All, long salleClasseId)
        {
            dgvEleves.DataSource = null;

            if (All)
            {
                
                EcoleFactory Factory = new EcoleFactory();
                List<Inscription> AllInscriptions= Factory.getAllInscriptionsFromEcole(_ecoleId, _anneeScolaireId);
                if (AllInscriptions.Count > 0)
                {
                    var source = new BindingSource();
                    var ListEleves = from ins in AllInscriptions
                                     select new
                                     {
                                         Matricule = ins.Eleve.Number,
                                         Nom = ins.Eleve.LastName,
                                         Prenom = ins.Eleve.FirstName,
                                         Classe = ins.SalleClasse.Code
                                     };
                    dgvEleves.AutoGenerateColumns = true;
                    source.DataSource = ListEleves;
                    dgvEleves.DataSource = source;
                    dgvEleves.Columns[0].Visible = false;
                }
            }
            else
            {
                if (salleClasseId != 0)
                {
                    EcoleFactory Factory = new EcoleFactory();
                    List<Eleve> AllEleves = Factory.getElevesFromSalleClasse(salleClasseId);
                    if (AllEleves.Count > 0)
                    {
                        var source = new BindingSource();
                        var ListEleves = from el in AllEleves
                                         select new
                                         {
                                             Matricule = el.Number,
                                             Nom = el.LastName,
                                             Prenom = el.FirstName
                                         };
                        dgvEleves.AutoGenerateColumns = true;
                        source.DataSource = ListEleves;
                        dgvEleves.DataSource = source;
                        dgvEleves.Columns[0].Visible = false;
                    }
                }
            }
        }

        private void LoadInscriptions()
        {
            dgvInscriptions.DataSource = null;
            EcoleFactory Factory = new EcoleFactory();
            List<Inscription> AllInscriptions = Factory.getInscriptionOfEcoleAndAnneeScolaire(_ecoleId, _anneeScolaireId);
            if (AllInscriptions.Count > 0)
            {
                var source = new BindingSource();
                var ListInscriptions = from insc in AllInscriptions
                                       select new
                                       {
                                           Id = insc.Id,
                                           Date = insc.DateInscription.ToShortDateString(),
                                           Eleve = insc.Eleve.ToString(),
                                           Classe = insc.SalleClasse.ToString()
                                       };
                dgvInscriptions.AutoGenerateColumns = true;
                source.DataSource = ListInscriptions;
                dgvInscriptions.DataSource = source;
                dgvInscriptions.Columns[0].Visible = false;
            }

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEleves.DataSource = null;
            if (cbClasses.SelectedIndex>0)
            {
                if (cbClasses.SelectedIndex == 1) // All eleves
                {
                    LoadEleves(true, 0);
                }
                else
                {
                    long salleClasseId = ((SalleClasse)cbClasses.SelectedItem).Id;
                    LoadEleves(false, salleClasseId);
                }
            }
        }

        private void CloseControlClicked(object sender, EventArgs e)
        {
            //May be add a pop up window asking user if really want to close the control/form
            pnlMain.Controls.Clear();
            //restore the menu panel to show the menu
            Control ctrl = this.Parent.Parent;
            Control ctrlMenuPanel = ctrl.Controls.Find("pnlMenu", true)[0];
            //Control ctrlMenuPanel = ctrlMainPanel.Controls.Find("pnlMenu", true)[0];
            ctrlMenuPanel.Visible = true;
        }
        private void AddRecordClicked(object sender, EventArgs e)
        {
            switch (tcEcole.SelectedIndex)
            {
                case 0:
                    {
                        CreateSalleClasse form = new CreateSalleClasse(_ecoleId, _anneeScolaireId, _userName);
                        form.ShowDialog();
                        LoadSalleClasses();
                        LoadSalleClassesComobBox();
                        break;
                    }
                case 1:
                    {
                        CreateEleve form = new CreateEleve();
                        form.ShowDialog();
                        LoadEleves(false,0);
                        break;
                    }
                case 2:
                    {
                        CreateInscription form = new CreateInscription(_ecoleId, _anneeScolaireId, _userName);
                        form.ShowDialog();
                        LoadInscriptions();
                        break;
                    }


                default:
                    break;
            }
        }

        private void DeleteRecordClicked(object sender, EventArgs e)
        {

        }

        private void UpdateRecordClicked(object sender, EventArgs e)
        {

        }

        private void ViewRecordClicked(object sender, EventArgs e)
        {

        }

        private void GenerateReportClicked(object sender, EventArgs e)
        {

        }

        private void PrintRecordsClicked(object sender, EventArgs e)
        {

        }

        private void tcEcole_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcEcole.SelectedIndex)
            {
                case 0:
                    {
                        //CreateSalleClasse form = new CreateSalleClasse(4, 1);
                        //form.ShowDialog();
                        //LoadSalleClasses();
                        break;
                    }
                case 1:
                    {
                        //CreateEnseignement form = new CreateEnseignement();
                        //form.ShowDialog();
                        //LoadEnseignements();
                        break;
                    }
                case 2:
                    {
                        LoadInscriptions();
                        break;
                    }
                case 3:
                    {
                        //CreateSerie form = new CreateSerie();
                        //form.ShowDialog();
                        //LoadSeries();
                        break;
                    }
                case 4:
                    {
                        //CreateClasse form = new CreateClasse();
                        //form.ShowDialog();
                        //LoadClasses();
                        break;
                    }

                default:
                    break;
            }
        }

    }
}
