using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SKLAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Controls
{
    public partial class SystemeScolaireActions : UserControl
    {

        public SystemeScolaireActions()
        {
            InitializeComponent();
            AddControls();
            LoadSystemeScolaires();
        }

        private void AddControls()
        {
            //Add a header
            ControlsHeader header = new ControlsHeader("Gestion des sytèmes scolaires de SUKULU");
            header.CloseClicked += new EventHandler(CloseControlClicked);
            header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(header);

            //Add a footer
            SKLAddDeleteViewUpdateReportPrint footer = new SKLAddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
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
        private void LoadSystemeScolaires()
        {
            dgvSystemeScolaires.DataSource = null;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<SystemeScolaire> AllSystemeScolaires = Factory.getAllSystemeScolaires();
            var source = new BindingSource();
            var ListSystemeScolaires = from ssco in AllSystemeScolaires
                                       select new
                                       {
                                           Id = ssco.Id,
                                           Name  = ssco.Name,
                                           PrimaryOwner = ssco.PrimaryOwner,
                                           Country = ssco.Country

                                       };
            dgvSystemeScolaires.AutoGenerateColumns = true;
            source.DataSource = ListSystemeScolaires;
            dgvSystemeScolaires.DataSource = source;
            dgvSystemeScolaires.Columns[0].Visible = false;
        }
        private void LoadEnseignements()
        {
            dgvEnseignements.DataSource = null;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<Enseignement> AllEnseignements = Factory.getAllEnseignements().OrderBy(ens => ens.SystemeScolaireId).ToList();
            var source = new BindingSource();
            var ListEnseignements = from ens in AllEnseignements
                                    select new
                                       {
                                           Id = ens.Id,
                                           Code = ens.Code,
                                           Name = ens.Name,
                                           SystemeScolaire = ens.SystemeScolaire.ToString()
                                       };
            dgvEnseignements.AutoGenerateColumns = true;
            source.DataSource = ListEnseignements;
            dgvEnseignements.DataSource = source;
            dgvEnseignements.Columns[0].Visible = false;
        }
        private void LoadNiveaux()
        {
            dgvNiveaux.DataSource = null;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<Niveau> AllNiveaux = Factory.getAllNiveaux().OrderBy(niv => niv.Enseignement.SystemeScolaireId)
                .ThenBy(niv => niv.EnseignementId)
                .ThenBy(niv => niv.Ranking)
                .ToList();
            var source = new BindingSource();
            var ListNiveaux = from niv in AllNiveaux
                                    select new
                                    {
                                        Id = niv.Id,
                                        Code = niv.Code,
                                        Name = niv.Name,
                                        Enseignement = niv.Enseignement.ToString(),
                                        SystemeScolaire = niv.Enseignement.SystemeScolaire.ToString()
                                    };
            dgvNiveaux.AutoGenerateColumns = true;
            source.DataSource = ListNiveaux;
            dgvNiveaux.DataSource = source;
            dgvNiveaux.Columns[0].Visible = false;
        }
        private void LoadSeries()
        {
            dgvSeries.DataSource = null;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<Serie> AllSeries = Factory.getAllSeries().OrderBy(ser => ser.Enseignement.SystemeScolaireId)
                .ThenBy(ser => ser.EnseignementId)
                .ToList();
            var source = new BindingSource();
            var ListNiveaux = from ser in AllSeries
                              select new
                              {
                                  Id = ser.Id,
                                  Code = ser.Code,
                                  Name = ser.Name,
                                  Enseignement = ser.Enseignement.ToString(),
                                  SystemeScolaire = ser.Enseignement.SystemeScolaire.ToString()
                              };
            dgvSeries.AutoGenerateColumns = true;
            source.DataSource = ListNiveaux;
            dgvSeries.DataSource = source;
            dgvSeries.Columns[0].Visible = false;
        }
        private void LoadClasses()
        {
            dgvClasses.DataSource = null;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<Classe> AllClasses= Factory.getAllClasses().OrderBy(cl => cl.Niveau.Enseignement.SystemeScolaireId)
                .ThenBy(cl => cl.Niveau.EnseignementId)
                .ThenBy(cl => cl.Niveau.Ranking)
                .ThenBy(cl => cl.Name)
                .ToList();
            var source = new BindingSource();
            var ListClasses = from cl in AllClasses
                              select new
                              {
                                  Id = cl.Id,
                                  Code = cl.Code,
                                  Name = cl.Name,
                                  Niveau = cl.Niveau.ToString(),
                                  Serie = (cl.Serie != null)?(cl.Serie.Code):(""),
                                  Enseignement = cl.Niveau.Enseignement.ToString(),
                                  SystemeScolaire = cl.Niveau.Enseignement.SystemeScolaire.ToString()
                              };
            dgvClasses.AutoGenerateColumns = true;
            source.DataSource = ListClasses;
            dgvClasses.DataSource = source;
            dgvClasses.Columns[0].Visible = false;
        }
        private void tcSystemeScolaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        LoadEnseignements();
                        break;
                    }
                case 2: 
                    {
                        LoadNiveaux();
                        break; 
                    }
                case 3:
                    {
                        LoadSeries();
                        break;
                    }
                case 4:
                    {
                        LoadClasses();
                        break;
                    }

                default:
                    break;
            }
        }
        private void CloseControlClicked(object sender, EventArgs e)
        {
            //May be add a pop up window asking user if really want to clsoe the control/form
            pnlMain.Controls.Clear();
            //restore the menu panel to show the menu
            Control ctrl = this.Parent.Parent;
            Control ctrlPanelMenu = ctrl.Controls.Find("pnlMenu", true)[0];
            ctrlPanelMenu.Visible = true;
        }

        private void AddRecordClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        CreateSystemeScolaire form = new CreateSystemeScolaire();
                        form.ShowDialog();
                        LoadSystemeScolaires();
                        break;
                    }
                case 1:
                    {
                        CreateEnseignement form = new CreateEnseignement();
                        form.ShowDialog();
                        LoadEnseignements();
                        break;
                    }
                case 2:
                    {
                        CreateNiveau form = new CreateNiveau();
                        form.ShowDialog();
                        LoadNiveaux();
                        break;
                    }
                case 3:
                    {
                        CreateSerie form = new CreateSerie();
                        form.ShowDialog();
                        LoadSeries();
                        break;
                    }
                case 4:
                    {
                        CreateClasse form = new CreateClasse();
                        form.ShowDialog();
                        LoadClasses();
                        break;
                    }

                default:
                    break;
            }
        }

        private void DeleteRecordClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private void UpdateRecordClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        if (dgvSystemeScolaires.SelectedRows.Count == 1)
                        {
                            long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
                            EditSystemeScolaire form = new EditSystemeScolaire(Id);
                            form.ShowDialog();
                            LoadSystemeScolaires();
                        }
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private void ViewRecordClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        if (dgvSystemeScolaires.SelectedRows.Count == 1)
                        {
                            long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
                            SystemeScolaireDetails form = new SystemeScolaireDetails(Id);
                            form.ShowDialog();
                            
                        }
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private void GenerateReportClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private void PrintRecordsClicked(object sender, EventArgs e)
        {
            switch (tcSystemeScolaire.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

    }
}
