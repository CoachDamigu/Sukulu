using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SKLAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Controls
{
    public partial class ClientUtilisateurResourcesActions : UserControl
    {
        string _userName;
        public SKLAddDeleteViewUpdateReportPrint footer = new SKLAddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
        public ClientUtilisateurResourcesActions(string userName)
        {
            _userName = userName;
            InitializeComponent();
            AddControls();
            LoadClientUserResources();
        }

        private void LoadClientUserResources()
        {
            UserManagementFactory umFactory = new UserManagementFactory();
            List<SKLClient> ListCLients = umFactory.getAllClient();

            Cursor.Current = Cursors.WaitCursor;
            tvClientUserResources.BeginUpdate();
            tvClientUserResources.Nodes.Clear();

            TreeNode Root = new TreeNode("SUKULU");
            tvClientUserResources.Nodes.Add(Root);
            int nodeClientsCount = 0;
            int nodeEcolesCount = 0;
            //int nodeUsersCount = 0;
            if (ListCLients.Count > 0)
            {
                
                foreach(SKLClient client in ListCLients)
                {
                    TreeNode clientNode = new TreeNode(client.Name);
                    clientNode.Tag = client;
                    tvClientUserResources.Nodes[0].Nodes.Add(clientNode);
                    List<Ecole> ListEcoles = umFactory.getClientEcoles(client.Id);
                    if (ListEcoles.Count > 0)
                    {
                        //nodeCount++;
                        foreach(Ecole ecole in ListEcoles)
                        {
                            TreeNode ecoleNode = new TreeNode(ecole.ShortName);
                            ecoleNode.Tag = ecole;
                            List<SKLUser> ListUsers = umFactory.getClientEcoleUsers(client.Id, ecole.Id);
                            tvClientUserResources.Nodes[0].Nodes[nodeClientsCount].Nodes.Add(ecoleNode);
                            if (ListUsers.Count > 0)
                            {
                                foreach(SKLUser user in ListUsers)
                                {
                                    TreeNode userNode = new TreeNode(user.Login + "(" + user.LastName + " " + user.FirstName + ")");
                                    userNode.Tag = user;
                                    tvClientUserResources.Nodes[0].Nodes[nodeClientsCount].Nodes[nodeEcolesCount].Nodes.Add(userNode);
                                }
                            }
                            nodeEcolesCount++;
                        }
                    }
                    nodeClientsCount++;
                }
                
            }
            Cursor.Current = Cursors.Default;
            tvClientUserResources.EndUpdate();
        }

        private void AddControls()
        {
            //Add a header
            ControlsHeader header = new ControlsHeader("Gestion des utilisateurs de SUKULU");
            header.CloseClicked += new EventHandler(CloseControlClicked);
            header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(header);

            //Add a footer
            //SKLAddDeleteViewUpdateReportPrint footer = new SKLAddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
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
            //May be add a pop up window asking user if really want to clsoe the control/form
            pnlMain.Controls.Clear();
            //restore the menu panel to show the menu
            Control ctrl = this.Parent.Parent;
            Control ctrlPanelMenu = ctrl.Controls.Find("pnlMenu", true)[0];
            ctrlPanelMenu.Visible = true;
        }
        private void AddRecordClicked(object sender, EventArgs e)
        {
            switch (tvClientUserResources.SelectedNode.Level)
            {
                case 0:
                    {
                        
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
                        SelectTypeUtilisateurToCreate form = new SelectTypeUtilisateurToCreate();
                        form.ShowDialog();
                        if (form._isUserTypeSelected)
                        {
                            SKLUserType _userType = form._userType;
                            int indexUserType = (int)form._userType;

                            if (_userType == SKLUserType.AdminEcole)
                            {
                                Ecole ecole = (Ecole)tvClientUserResources.SelectedNode.Tag;
                                CreateSKLEcoleAdminUser createUserForm = new CreateSKLEcoleAdminUser(_userName, ecole.Id);
                                createUserForm.ShowDialog();
                            }

                            if (_userType == SKLUserType.Eleve)
                            {

                            }

                            if (_userType == SKLUserType.Parent)
                            {

                            }

                            if (_userType == SKLUserType.Enseignant)
                            {

                            }
                        }
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

        private void DeleteRecordClicked(object sender, EventArgs e)
        {
            //switch (tcUtilisateurs.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            break;
            //        }
            //    case 1:
            //        {

            //            break;
            //        }
            //    case 2:
            //        {

            //            break;
            //        }
            //    case 3:
            //        {

            //            break;
            //        }
            //    case 4:
            //        {

            //            break;
            //        }

            //    default:
            //        break;
            //}
        }

        private void UpdateRecordClicked(object sender, EventArgs e)
        {
            //switch (tcUtilisateurs.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            //if (dgvSystemeScolaires.SelectedRows.Count == 1)
            //            //{
            //            //    long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
            //            //    EditSystemeScolaire form = new EditSystemeScolaire(Id);
            //            //    form.ShowDialog();
            //            //    LoadSystemeScolaires();
            //            //}
            //            break;
            //        }
            //    case 1:
            //        {

            //            break;
            //        }
            //    case 2:
            //        {

            //            break;
            //        }
            //    case 3:
            //        {

            //            break;
            //        }
            //    case 4:
            //        {

            //            break;
            //        }

            //    default:
            //        break;
            //}
        }

        private void ViewRecordClicked(object sender, EventArgs e)
        {
            //switch (tcUtilisateurs.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            //if (dgvSystemeScolaires.SelectedRows.Count == 1)
            //            //{
            //            //    long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
            //            //    SystemeScolaireDetails form = new SystemeScolaireDetails(Id);
            //            //    form.ShowDialog();

            //            //}
            //            break;
            //        }
            //    case 1:
            //        {

            //            break;
            //        }
            //    case 2:
            //        {

            //            break;
            //        }
            //    case 3:
            //        {

            //            break;
            //        }
            //    case 4:
            //        {

            //            break;
            //        }

            //    default:
            //        break;
            //}
        }

        private void GenerateReportClicked(object sender, EventArgs e)
        {
            //switch (tcUtilisateurs.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            break;
            //        }
            //    case 1:
            //        {

            //            break;
            //        }
            //    case 2:
            //        {

            //            break;
            //        }
            //    case 3:
            //        {

            //            break;
            //        }
            //    case 4:
            //        {

            //            break;
            //        }

            //    default:
            //        break;
            //}
        }

        private void PrintRecordsClicked(object sender, EventArgs e)
        {
            //switch (tcUtilisateurs.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            break;
            //        }
            //    case 1:
            //        {

            //            break;
            //        }
            //    case 2:
            //        {

            //            break;
            //        }
            //    case 3:
            //        {

            //            break;
            //        }
            //    case 4:
            //        {

            //            break;
            //        }

            //    default:
            //        break;
            //}
        }

        private void tvClientUserResources_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            switch (tvClientUserResources.SelectedNode.Level)
            {
                case 0: // root node, add client
                    {
                        footer.btnAdd.Enabled = true;
                        toolTip.SetToolTip(footer.btnAdd, "Ajouter un nouveau client à SUKULU");
                        break;
                    }
                case 1: //Client selected, add ecole
                    {
                        footer.btnAdd.Enabled = true;
                        toolTip.SetToolTip(footer.btnAdd, "Ajouter une école au client");
                        break;
                    }
                case 2: // ecole selected, add users
                    {
                        footer.btnAdd.Enabled = true;
                        toolTip.SetToolTip(footer.btnAdd, "Ajouter un utilisateur à l'école");

                        

                        break;
                    }
                case 3:
                    {
                        footer.btnAdd.Enabled = true;
                        toolTip.SetToolTip(footer.btnAdd, "Ajouter une resource à l'utilisateur");
                        break;
                    }
                default: 
                    {
                        footer.btnAdd.Enabled = false;
                        break;
                    }
            }
        }
    }
}
