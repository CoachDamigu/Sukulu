using Sukulu.DataAccessLibrary.Enums;
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
    public partial class CreateSKLUserOthers : Form
    {
        string _username;
        SKLUserType _userType;
        public long _userId;
        SKLClient _client;
        Ecole _ecole;
        public CreateSKLUserOthers(string userName, SKLUserType userType, SKLClient client, Ecole ecole  )
        {
            _username = userName;
            _userType = userType;
            _client = client;
            _ecole = ecole;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserManagementFactory Factory = new UserManagementFactory();
            if ((!string.IsNullOrEmpty(tbLogin.Text) && (!string.IsNullOrWhiteSpace(tbLogin.Text))) &&
                (!string.IsNullOrEmpty(tbPassword.Text) && (!string.IsNullOrWhiteSpace(tbPassword.Text))) &&
                (!string.IsNullOrEmpty(tbVerifyPassword.Text) && (!string.IsNullOrWhiteSpace(tbVerifyPassword.Text))))
            {
                // Create the user
                byte[] salt = PasswordUtilities.CreateSalt();
                string hash = PasswordUtilities.CreateHash(tbPassword.Text);
                _userId = Factory.createSKLUser(tbLogin.Text.Trim().ToUpper(), tbFirstName.Text.Trim(), tbLastName.Text.Trim(),
                    tbEmail.Text.Trim(), hash, salt, true, false, _userType, _username, DateTime.Now);

                if (_userType == SKLUserType.AdminClient)
                {
                    // add client to resources
                    long id = Factory.createUserResource(_userId, SKLResourceType.Client, _client.Id, false, _username, DateTime.Now);
                }

                if (_userType == SKLUserType.AdminEcole)
                {
                    // add Ecole to resources
                    long id = Factory.createUserResource(_userId, SKLResourceType.Ecole, _ecole.Id, false, _username, DateTime.Now);
                }
            }
        }
    }
}
