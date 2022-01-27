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
    public partial class EnseignementActions : UserControl
    {
        long _ecoleId, _anneeScolaireId;
        string _userName;
        public EnseignementActions(long ecoleId, long anneeScolaireId, string userName)
        {
            _ecoleId = ecoleId;
            _anneeScolaireId = anneeScolaireId;
            _userName = userName;
            InitializeComponent();
            AddControls();
            LoadEnseignants();
            LoadSalleClassesComobBox();
            LoadEnseignantsComboBox();
            LoadMatieres(true, 0);
        }

        private void LoadSalleClassesComobBox()
        {
            cbSalleClasse.Items.Clear();
            cbSalleClasse.Items.Add("Choisissez une classe");
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> AllSalleClasses = Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId).OrderBy(sc => sc.Classe.Niveau.Ranking)
                .ThenBy(sc => sc.Code).ToList();
            if (AllSalleClasses.Count > 0)
                foreach (SalleClasse sc in AllSalleClasses)
                    cbSalleClasse.Items.Add(sc);
            cbSalleClasse.SelectedIndex = 0;
        }

        private void LoadEnseignantsComboBox()
        {
            cbEnseignants.Items.Clear();
            cbEnseignants.Items.Add("Choisissez un professeur");
            EnseignementFactory Factory = new EnseignementFactory();
            List<Enseignant> ListEnseignants = Factory.getAllEnseignants();
            if (ListEnseignants.Count > 0)
                foreach (Enseignant ens in ListEnseignants)
                    cbEnseignants.Items.Add(ens);
            cbEnseignants.SelectedIndex = 0;
        }

        private void LoadEnseignants()
        {
            dgvEnseignants.DataSource = null;
            EnseignementFactory Factory = new EnseignementFactory();
            List<Enseignant> AllEnseignants = Factory.getAllEnseignants();
            if (AllEnseignants.Count > 0)
            {
                var source = new BindingSource();
                var ListEnseignants = from ens in AllEnseignants
                                      select new
                                       {
                                           Id = ens.Id,
                                           Nom = ens.LastName,
                                           Prenom = ens.FirstName,
                                           DateNaissance = ens.DateOfBirth.ToShortDateString(),
                                           Sexe = ens.Sexe,
                                           Email = ens.Email,
                                           Phone = ens.Phone
                                       };
                dgvEnseignants.AutoGenerateColumns = true;
                source.DataSource = ListEnseignants;
                dgvEnseignants.DataSource = source;
                dgvEnseignants.Columns[0].Visible = false;
            }
        }


        public void AddControls()
        {
            //Add a header
            Header header = new Header("Gestion de l'enseignement");
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

        private void LoadPortfolioEnseignants()
        {
            dgvPortfolioEnseignant.DataSource = null;
            if (cbEnseignants.SelectedIndex > 0 && _anneeScolaireId > 0 )
            {
                long enseignantId = ((Enseignant)cbEnseignants.SelectedItem).Id;
                EnseignementFactory Factory = new EnseignementFactory();

                List<PortfolioEnseignant> ListPortfolios = Factory.getEnseigantPortfolioForAnneeScolairePerEcole(_ecoleId, _anneeScolaireId, enseignantId);

                if (ListPortfolios.Count > 0)
                {
                    var source = new BindingSource();
                    var ListPortfolioEnseignants= from pf in ListPortfolios
                                                  select new
                                       {
                                           Id = pf.Id,
                                           Classe = pf.SalleClasseMatiere.SalleClasse.Code,
                                           Matiere = pf.SalleClasseMatiere.Matiere.Name,
                                           Debut = pf.StartDate.ToShortDateString(),
                                           Fin = pf.EndDate.ToShortDateString()
                                       };
                    dgvPortfolioEnseignant.AutoGenerateColumns = true;
                    source.DataSource = ListPortfolioEnseignants;
                    dgvPortfolioEnseignant.DataSource = source;
                    dgvPortfolioEnseignant.Columns[0].Visible = false;
                }
            }
        }
        private void LoadMatieres(Boolean all, long salleClasseId)
        {
            
            EnseignementFactory Factory = new EnseignementFactory();
            if (all)
            {
                dgvMatieres.DataSource = null;
                List<Matiere> AllMatieres = Factory.getAllMatieres().OrderBy(m => m.Name).ThenBy(m => m.Code).ToList();

                if (AllMatieres.Count > 0)
                {
                    var source = new BindingSource();
                    var ListMatieres = from m in AllMatieres
                                       select new
                                       {
                                           Id = m.Id,
                                           Name = m.Name,
                                           Code = m.Code
                                       };
                    dgvMatieres.AutoGenerateColumns = true;
                    source.DataSource = ListMatieres;
                    dgvMatieres.DataSource = source;
                    dgvMatieres.Columns[0].Visible = false;
                }
            }
            else
            {
                dgvMatiereSalleClasse.DataSource = null;
                List<SalleClasseMatiere> AllMatieres = Factory.getSalleClasseMatiere(salleClasseId).ToList();

                if (AllMatieres.Count > 0)
                {
                    var source = new BindingSource();
                    var ListMatieres = from scm in AllMatieres
                                       select new
                                       {
                                           Id = scm.Id,
                                           Name = scm.Matiere.Name,
                                           Coefficient = scm.Coefficient
                                       };
                    dgvMatiereSalleClasse.AutoGenerateColumns = true;
                    source.DataSource = ListMatieres;
                    dgvMatiereSalleClasse.DataSource = source;
                    dgvMatiereSalleClasse.Columns[0].Visible = false;
                }
            }
        }

        private void cbSalleClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMatiereSalleClasse.DataSource = null;
            if (cbSalleClasse.SelectedIndex > 0)
            {
                    long salleClasseId = ((SalleClasse)cbSalleClasse.SelectedItem).Id;
                    LoadMatieres(false,salleClasseId);
            }
        }
        private void AddRecordClicked(object sender, EventArgs e)
        {
            switch (tcEnseignement.SelectedIndex)
            {
                case 0:
                    {
                        LoadMatieres(true, 0);
                        break;
                    }
                case 1:
                    {
                        if (cbSalleClasse.SelectedIndex > 0)
                        {
                            EcoleFactory Factory = new EcoleFactory();
                            long salleClasseId = ((SalleClasse)cbSalleClasse.SelectedItem).Id;
                            CreateSalleClasseMatiere form = new CreateSalleClasseMatiere(salleClasseId, _userName);
                            form.ShowDialog();
                            LoadMatieres(false, salleClasseId);
                        }
                        break;
                    }
                case 2:
                    {
                        CreateEnseignant form = new CreateEnseignant(_userName);
                        form.ShowDialog();
                        LoadEnseignants();
                        break;
                    }

                case 3:
                    {
                        if (cbEnseignants.SelectedIndex > 0)
                        {
                            //EnseignementFactory Factory = new EnseignementFactory();
                            long enseignantId = ((Enseignant)cbEnseignants.SelectedItem).Id;
                            CreatePortfolioEnseignant form = new CreatePortfolioEnseignant(_ecoleId, _anneeScolaireId, enseignantId, _userName);
                            form.ShowDialog();
                            LoadPortfolioEnseignants();
                        }
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

        private void cbEnseignants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnseignants.SelectedIndex > 0)
            {
                dgvPortfolioEnseignant.DataSource = null;

                long enseignantId = ((Enseignant)cbEnseignants.SelectedItem).Id;
                EnseignementFactory Factory = new EnseignementFactory();
                long ecoleId = Properties.Settings.Default.EcoleId;
                long anneeScolaireId = Properties.Settings.Default.AnneeScolaireId;
                List<PortfolioEnseignant> AllPortfolio = Factory.getEnseigantPortfolioForAnneeScolairePerEcole(ecoleId, anneeScolaireId, enseignantId);

                
                if (AllPortfolio.Count > 0)
                {
                    var source = new BindingSource();
                    var ListPortfolios = from pf in AllPortfolio
                                         select new
                                          {
                                              Id = pf.Id,
                                              NomClasse = pf.SalleClasseMatiere.SalleClasse.Code,
                                              Matiere = pf.SalleClasseMatiere.Matiere.Name,
                                              Debut = pf.StartDate.ToShortDateString(),
                                              Fin = pf.EndDate.ToShortDateString()
                                          };
                    dgvPortfolioEnseignant.AutoGenerateColumns = true;
                    source.DataSource = ListPortfolios;
                    dgvPortfolioEnseignant.DataSource = source;
                    dgvPortfolioEnseignant.Columns[0].Visible = false;
                }

            }
        }

        private void PrintRecordsClicked(object sender, EventArgs e)
        {

        }
    }
}
