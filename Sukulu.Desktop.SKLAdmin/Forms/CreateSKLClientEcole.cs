using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Forms
{
    public partial class CreateSKLClientEcole : Form
    {
        long _clientId;
        string _userName;
        public Boolean _clientEcoleCreated = false;
        public CreateSKLClientEcole(string userName, long clientId)
        {
            _clientId = clientId;
            _userName = userName;
            InitializeComponent();
            LoadEcoles();

            UserManagementFactory umFactory = new UserManagementFactory();
            SKLClient client = umFactory.getSKLClientById(_clientId);
            lblClient.Text = client.Name;

        }

        public void LoadEcoles()
        {
            cbEcoles.Items.Clear();
            cbEcoles.Items.Add("Choisissez une école");
            UserManagementFactory umFactory = new UserManagementFactory();
            List<Ecole> ListEcolesDipo = umFactory.getEcolesWithoutClient();
            if (ListEcolesDipo.Count > 0)
                foreach (Ecole ecole in ListEcolesDipo)
                    cbEcoles.Items.Add(ecole);
            cbEcoles.SelectedIndex = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbEcoles.SelectedIndex > 0)
            {
                UserManagementFactory umFactory = new UserManagementFactory();
                Ecole ecole = (Ecole)cbEcoles.SelectedItem;
                Boolean isClientEcoleExist = umFactory.isClientEcoleExist(_clientId, ecole.Id);
                if (!isClientEcoleExist)
                {
                    long Id = umFactory.createSKLClientEcole(_clientId, ecole.Id, _userName, DateTime.Now);
                    _clientEcoleCreated = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("L'école choisie fait déjà parti du portfolio d'un autre client");
                }
            }
            else
            {
                MessageBox.Show("Il faut choisir une école");
            }
        }
    }
}
