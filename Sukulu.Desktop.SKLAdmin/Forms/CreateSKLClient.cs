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
    public partial class CreateSKLClient : Form
    {
        string _userName;
        public Boolean _clientCreated = false;
        public CreateSKLClient(string userName)
        {
            _userName = userName;
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text) && !! !string.IsNullOrWhiteSpace(tbName.Text))
            {
                UserManagementFactory umFactory = new UserManagementFactory();
                long Id = umFactory.createSKLClient(tbName.Text.Trim(), tbNotes.Text.Trim(), _userName, DateTime.Now);
                _clientCreated = true;
                this.Close();
            }
        }
    }
}
