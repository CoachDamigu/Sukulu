using Sukulu.DataAccessLibrary.Enums;
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
    public partial class ClientsEcoleUtilisateursResourcesActions : UserControl
    {
        string _userName;
        SKLAddDeleteViewUpdateReportPrint footer;
        //SKLUserType _userType;
        public ClientsEcoleUtilisateursResourcesActions(string userName)
        {
            _userName = userName;
            InitializeComponent();
            LoadClientComboBoxes();
            LoadClients();
            AddControls();
        }

        private void LoadClientComboBoxes()
        {
            cbClientsForEcoles.Items.Clear();
            cbClientsForUsers.Items.Clear();
            cbClientsForResources.Items.Clear();
            cbClientsForEcoles.Items.Add("Choisissez un client");
            cbClientsForUsers.Items.Add("Choisissez un client");
            cbClientsForResources.Items.Add("Choisissez un client");
            
            UserManagementFactory umFactory = new UserManagementFactory();
            List<SKLClient> ListClients = umFactory.getAllClient();
            foreach (SKLClient client in ListClients)
            {
                cbClientsForEcoles.Items.Add(client);
                cbClientsForUsers.Items.Add(client);
                cbClientsForResources.Items.Add(client);
            }

            cbClientsForEcoles.SelectedIndex = 0;
            cbClientsForUsers.SelectedIndex = 0;
            cbClientsForResources.SelectedIndex = 0;

        }

        private void LoadClients()
        {
            dgvClients.DataSource = null;
            UserManagementFactory umFactory = new UserManagementFactory();
            List<SKLClient> ListClients = umFactory.getAllClient();
            if (ListClients.Count > 0)
            {
                var source = new BindingSource();
                var clients = from c in ListClients
                              select new
                             {
                                 Id = c.Id,
                                 Nom = c.Name
                             };
                dgvClients.AutoGenerateColumns = true;
                source.DataSource = clients;
                dgvClients.DataSource = source;
                dgvClients.Columns[0].Visible = false;
            }
        }

        private void LoadEcoles(long clientId)
        {
            dgvEcoles.DataSource = null;
            UserManagementFactory umfactory = new UserManagementFactory();
            List<Ecole> ListEcoles = umfactory.getClientEcoles(clientId);

            if (ListEcoles.Count > 0)
            {
                var source = new BindingSource();
                var ecoles = from ec in ListEcoles
                             select new
                              {
                                  Id = ec.Id,
                                  Nom = ec.FullName,
                                  SystemeScolaire = ec.SystemeScolaire.Name,
                                  Phone = ec.MainPhone,
                                  Email = ec.MainEmail
                              };
                dgvEcoles.AutoGenerateColumns = true;
                source.DataSource = ecoles;
                dgvEcoles.DataSource = source;
                dgvEcoles.Columns[0].Visible = false;
            }
        }

        private void LoadUsers(long clientId, long ecoleId)
        {
            dgvUsers.DataSource = null;
            UserManagementFactory umfactory = new UserManagementFactory();
            List<SKLUser> ListUsers = umfactory.getClientEcoleUsers(clientId, ecoleId);
            if (ListUsers.Count > 0)
            {
                var source = new BindingSource();
                var users = from u in ListUsers
                            select new
                            {
                                Id = u.Id,
                                Login = u.Login,
                                Utilisateur = u.LastName + " " + u.FirstName
                             };
                dgvUsers.AutoGenerateColumns = true;
                source.DataSource = users;
                dgvUsers.DataSource = source;
                dgvUsers.Columns[0].Visible = false;
            }
        }

        private void LoadResources(long userId)
        {
            dgvResources.DataSource = null;
            UserManagementFactory umfactory = new UserManagementFactory();
            List<SKLUserResource> ListResources = umfactory.getUserAllResources(userId);
            if (ListResources.Count > 0)
            {
                var source = new BindingSource();
                var resources = from r in ListResources
                                select new
                                {
                                    Id = r.Id,
                                    Type = r.ResourceType.GetDisplayName(),
                                    ReourceId = r.ResourceId,
                                    Resource = getResourceDisplay(r.ResourceType, r.ResourceId)
                            };
                dgvResources.AutoGenerateColumns = true;
                source.DataSource = resources;
                dgvResources.DataSource = source;
                dgvResources.Columns[0].Visible = false;
                dgvResources.Columns[2].Visible = false;
            }
        }

        private void AddControls()
        {
            //Add a header
            ControlsHeader header = new ControlsHeader("Gestion des utilisateurs de SUKULU");
            header.CloseClicked += new EventHandler(CloseControlClicked);
            header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(header);

            //Add a footer
            footer = new SKLAddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
            footer.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(footer);

            footer.btnDelete.Visible = false;
            footer.btnPrint.Visible = false;
            footer.btnReport.Visible = false;
            footer.btnUpdate.Visible = false;
            footer.btnView.Visible = false;


            footer.AddClicked += new EventHandler(AddRecordClicked);
            footer.DeleteClicked += new EventHandler(DeleteRecordClicked);
            footer.UpdateClicked += new EventHandler(UpdateRecordClicked);
            footer.ViewClicked += new EventHandler(ViewRecordClicked);
            footer.ReportClicked += new EventHandler(GenerateReportClicked);
            footer.PrintClicked += new EventHandler(PrintRecordsClicked);
        }

        private void AddEcolesToSKLAdminUser(long userId, SKLResourceType resourceType)
        {
            EcoleFactory Factory = new EcoleFactory();
            List<Ecole> ListEcoles = Factory.getAllEcoles();
            if (ListEcoles.Count > 0)
            {
                UserManagementFactory umFactory = new UserManagementFactory();
                long Id;
                foreach (Ecole ecole in ListEcoles)
                {
                    Id = umFactory.createUserResource(userId, resourceType, ecole.Id, false, _userName, DateTime.Now);
                }
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
            switch (tcUtilisateurs.SelectedIndex)
            {
                case 0: //Créer un clients
                    {
                        CreateSKLClient form = new CreateSKLClient(_userName);
                        form.ShowDialog();
                        if (form._clientCreated)
                        {
                            LoadClientComboBoxes();
                            LoadClients();
                        }
                        break;
                    }
                case 1: // Ajouter des ecoles aux clients
                    {
                        if (cbClientsForEcoles.SelectedIndex > 0)
                        {
                            int index = cbClientsForEcoles.SelectedIndex;
                            SKLClient client = (SKLClient)cbClientsForEcoles.SelectedItem;
                            CreateSKLClientEcole form = new CreateSKLClientEcole(_userName, client.Id);
                            form.ShowDialog();
                            if (form._clientEcoleCreated)
                            {
                                LoadClientComboBoxes();
                                cbClientsForEcoles.SelectedIndex = index;
                                LoadEcoles(client.Id);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Il faut d'abord choisir un client");
                        }
                        break;
                    }
                case 2: //Créer un utilisateur pour l'ecole
                    {
                        if (cbClientsForUsers.SelectedIndex > 0 && cbEcolesForUsers.SelectedIndex > 0)
                        {
                            int indexClient = cbClientsForUsers.SelectedIndex;
                            int indexEcole = cbEcolesForUsers.SelectedIndex;
                            SKLClient client = (SKLClient)cbClientsForUsers.SelectedItem;
                            Ecole ecole = (Ecole)cbEcolesForUsers.SelectedItem;
                            SelectTypeUtilisateurToCreate form = new SelectTypeUtilisateurToCreate();
                            form.ShowDialog();
                            if (form._isUserTypeSelected)
                            {
                                SKLUserType typeUser = form._userType;
                                if (typeUser == SKLUserType.Eleve || typeUser == SKLUserType.Enseignant)
                                {
                                    CreateSKLUserEleveEnseignant userForm = new CreateSKLUserEleveEnseignant(_userName, form._userType);
                                    userForm.ShowDialog();
                                }
                                else
                                {
                                    CreateSKLUserOthers userForm = new CreateSKLUserOthers(_userName, form._userType, client, ecole);
                                }
                                //if (userForm._)
                            }
                        }
                        break;
                    }
                case 3: //Add resource
                    {
                        //CreateSerie form = new CreateSerie();
                        //form.ShowDialog();
                        //LoadSeries();
                        break;
                    }
                default:
                    break;
            }
        }

        private void DeleteRecordClicked(object sender, EventArgs e)
        {
            switch (tcUtilisateurs.SelectedIndex)
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
            switch (tcUtilisateurs.SelectedIndex)
            {
                case 0:
                    {
                        //if (dgvSystemeScolaires.SelectedRows.Count == 1)
                        //{
                        //    long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
                        //    EditSystemeScolaire form = new EditSystemeScolaire(Id);
                        //    form.ShowDialog();
                        //    LoadSystemeScolaires();
                        //}
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
            switch (tcUtilisateurs.SelectedIndex)
            {
                case 0:
                    {
                        //if (dgvSystemeScolaires.SelectedRows.Count == 1)
                        //{
                        //    long Id = ((long)dgvSystemeScolaires.SelectedRows[0].Cells[0].Value);
                        //    SystemeScolaireDetails form = new SystemeScolaireDetails(Id);
                        //    form.ShowDialog();

                        //}
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
            switch (tcUtilisateurs.SelectedIndex)
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
            switch (tcUtilisateurs.SelectedIndex)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvUsers.DataSource = null;
            List<SKLUser> ListUsers = new List<SKLUser>();
            UserManagementFactory umFactory = new UserManagementFactory();
            ListUsers = umFactory.getAllUsers();
            //if (cbUserType.SelectedIndex > 0 || !string.IsNullOrEmpty(tbLogin.Text) || !string.IsNullOrWhiteSpace(tbLogin.Text)
            //    || !string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text)
            //    || !string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text)
            //    || !string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
            //{
            //    if (cbUserType.SelectedIndex > 0)
            //        ListUsers = ListUsers.Where(u => u.UserType == (SKLUserType)(cbUserType.SelectedIndex - 1)).ToList();
            //    if (!string.IsNullOrEmpty(tbLogin.Text) || !string.IsNullOrWhiteSpace(tbLogin.Text))
            //        ListUsers = ListUsers.Where(u => u.Login.Contains(tbLogin.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
            //    if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
            //        ListUsers = ListUsers.Where(u => u.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
            //    if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
            //        ListUsers = ListUsers.Where(u => u.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
            //    if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
            //        ListUsers = ListUsers.Where(u => u.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
            //}

            // Fill the dataGrid for users
            if (ListUsers.Count > 0)
            {
                var source = new BindingSource();
                var Users = from user in ListUsers
                            select new
                            {
                                Id = user.Id,
                                Utilisateur = user.LastName + " " + user.FirstName,
                                Login = user.Login,
                                Email = user.Email
                            };
                dgvUsers.AutoGenerateColumns = true;
                source.DataSource = Users;
                dgvUsers.DataSource = source;
                dgvUsers.Columns[0].Visible = false;
            }

            Cursor.Current = Cursors.Default;
        }

        private void cbClientsForEcoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientsForEcoles.SelectedIndex > 0)
            {
                long clientId = ((SKLClient)cbClientsForEcoles.SelectedItem).Id;
                LoadEcoles(clientId);
            }
            else
            {
                LoadEcoles(0);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            dgvResources.DataSource = null;
            if (dgvUsers.SelectedRows.Count == 1)
            {
                UserManagementFactory umFactory = new UserManagementFactory();
                long userId = (long)dgvUsers.SelectedRows[0].Cells[0].Value;
                List<SKLUserResource> ListResources = umFactory.getUserAllResources(userId);
                if (ListResources.Count > 0)
                {
                    var source = new BindingSource();
                    var resources = from r in ListResources
                                    select new
                                    {
                                        Id = r.Id,
                                        TypeResource = r.ResourceType.GetDisplayName(),
                                        ResourceId = r.ResourceId,
                                        Resource = getResourceName(r.ResourceType, r.ResourceId)
                                    };
                    dgvResources.AutoGenerateColumns = true;
                    source.DataSource = resources;
                    dgvResources.DataSource = source;
                    dgvResources.Columns[0].Visible = false;
                    dgvResources.Columns[2].Visible = false;
                }
            }
        }

        private string getResourceName(SKLResourceType resourceType, long resourceId)
        {
            EcoleFactory eFactory = new EcoleFactory();
            string resourceDisplay = "";
            if (resourceType == SKLResourceType.Ecole)
            {
                resourceDisplay = eFactory.getEcoleById(resourceId).FullName;
            };
            if (resourceType == SKLResourceType.Classe)
            {
                resourceDisplay = eFactory.getSalleClasseById(resourceId).Code;
            };
            if (resourceType == SKLResourceType.Eleve)
            {
                resourceDisplay = eFactory.getEleveById(resourceId).ToString();
            }
            return resourceDisplay;
        }

        private void cbEcolesForUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            long clientId;
            long ecoleId;

            if (cbClientsForUsers.SelectedIndex == 0)
                clientId = 0;
            else
                clientId = ((SKLClient)cbClientsForUsers.SelectedItem).Id;
            if (cbEcolesForUsers.SelectedIndex == 0)
                ecoleId = 0;
            else
                ecoleId = ((Ecole)cbEcolesForUsers.SelectedItem).Id;

            LoadUsers(clientId, ecoleId);
        }

        private void cbClientsForUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            long clientId;
            long ecoleId;

            if (cbClientsForUsers.SelectedIndex <= 0)
                clientId = 0;
            else
                clientId = ((SKLClient)cbClientsForUsers.SelectedItem).Id;
            if (cbEcolesForUsers.SelectedIndex <= 0)
                ecoleId = 0;
            else
                ecoleId = ((Ecole)cbEcolesForUsers.SelectedItem).Id;

            LoadCBEcolesForUsers(clientId);
            LoadUsers(clientId, ecoleId);
        }

        private void LoadCBEcolesForUsers(long clientId)
        {
            cbEcolesForUsers.Items.Clear();
            cbEcolesForUsers.Items.Add("Choisissez une école");
            UserManagementFactory umFactory = new UserManagementFactory();
            List<Ecole> ListEcoles = umFactory.getClientEcoles(clientId);
            if (ListEcoles.Count > 0)
                foreach (Ecole ecole in ListEcoles)
                    cbEcolesForUsers.Items.Add(ecole);
            cbEcolesForUsers.SelectedIndex = 0;
        }

        private void cbClientsForResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            long clientId;
            long ecoleId;
            long userId;

            if (cbClientsForResources.SelectedIndex <= 0)
                clientId = 0;
            else
                clientId = ((SKLClient)cbClientsForResources.SelectedItem).Id;

            if (cbEcoleForResources.SelectedIndex <= 0)
                ecoleId = 0;
            else
                ecoleId = ((Ecole)cbEcoleForResources.SelectedItem).Id;

            if (cbUsersForResources.SelectedIndex <= 0)
                userId = 0;
            else
                userId = ((SKLUser)cbUsersForResources.SelectedItem).Id;

            LoadCBEcolesForResources(clientId);
            LoadCBUsersForResources(clientId, ecoleId);
            LoadResources(userId);

        }

        private void cbEcoleForResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            long clientId;
            long ecoleId;
            long userId;

            if (cbClientsForResources.SelectedIndex <= 0)
                clientId = 0;
            else
                clientId = ((SKLClient)cbClientsForResources.SelectedItem).Id;

            if (cbEcoleForResources.SelectedIndex <= 0)
                ecoleId = 0;
            else
                ecoleId = ((Ecole)cbEcoleForResources.SelectedItem).Id;

            if (cbUsersForResources.SelectedIndex <= 0)
                userId = 0;
            else
                userId = ((SKLUser)cbUsersForResources.SelectedItem).Id;

            //LoadCBEcolesForResources(ecoleId);
            LoadCBUsersForResources(clientId, ecoleId);
            LoadResources(userId);
        }


        private void LoadCBEcolesForResources(long clientId)
        {
            cbEcoleForResources.Items.Clear();
            cbEcoleForResources.Items.Add("Choisissez une école");
            UserManagementFactory umFactory = new UserManagementFactory();
            List<Ecole> ListEcoles = umFactory.getClientEcoles(clientId);
            if (ListEcoles.Count > 0)
                foreach (Ecole ecole in ListEcoles)
                    cbEcoleForResources.Items.Add(ecole);
            cbEcoleForResources.SelectedIndex = 0;
        }

        private void LoadCBUsersForResources(long clientId, long ecoleId)
        {
            cbUsersForResources.Items.Clear();
            cbUsersForResources.Items.Add("Choisissez un utilisateur");
            UserManagementFactory umFactory = new UserManagementFactory();
            List<SKLUser> ListUsers = umFactory.getClientEcoleUsers(clientId, ecoleId);
            if (ListUsers.Count > 0)
                foreach (SKLUser user in ListUsers)
                    cbUsersForResources.Items.Add(user);
            cbUsersForResources.SelectedIndex = 0;
        }

        private string getResourceDisplay(SKLResourceType resourceType, long resourceId)
        {
            string display = "";
            EcoleFactory factory = new EcoleFactory();
            if (resourceType == SKLResourceType.Ecole)
            {
                display = factory.getEcoleById(resourceId).FullName;
            }
            if (resourceType == SKLResourceType.Classe)
            {
                display = factory.getSalleClasseById(resourceId).Code;
            }
            if (resourceType == SKLResourceType.Eleve)
            {
                display = factory.getEleveById(resourceId).ToString();
            }

            return display;
        }

        private void cbUsersForResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            long userId;
            if (cbUsersForResources.SelectedIndex <= 0)
                userId = 0;
            else
                userId = ((SKLUser)cbUsersForResources.SelectedItem).Id;
            LoadResources(userId);
        }

        private void tcUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
