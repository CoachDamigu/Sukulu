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
    public partial class CreateSKLEcoleAdminUser : Form
    {
        string _username;
        //SKLUserType _userType;
        public long _userId;
        long _ecoleId;
        public CreateSKLEcoleAdminUser(string userName, long ecoleId)
        {
            _username = userName;
            _ecoleId = ecoleId;
            //_userType = userType;
            InitializeComponent();
            EcoleFactory factory = new EcoleFactory();
            lblEcole.Text = factory.getEcoleById(_ecoleId).FullName;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(tbLastName.Text) && (!string.IsNullOrWhiteSpace(tbLastName.Text))) &&
                (!string.IsNullOrEmpty(tbFirstName.Text) && (!string.IsNullOrWhiteSpace(tbFirstName.Text))) &&
                (!string.IsNullOrEmpty(tbEmail.Text) && (!string.IsNullOrWhiteSpace(tbEmail.Text))) &&
                (!string.IsNullOrEmpty(tbLogin.Text) && (!string.IsNullOrWhiteSpace(tbLogin.Text))) &&
                (!string.IsNullOrEmpty(tbPassword.Text) && (!string.IsNullOrWhiteSpace(tbPassword.Text))) &&
                (!string.IsNullOrEmpty(tbVerifyPassword.Text) && (!string.IsNullOrWhiteSpace(tbVerifyPassword.Text))))
            {
                if (string.Compare(tbPassword.Text, tbVerifyPassword.Text) == 0)
                {
                    UserManagementFactory Factory = new UserManagementFactory();
                    Boolean isLoginUsed = Factory.isLoginExist(tbLogin.Text);

                    if (!isLoginUsed)
                    {
                        //Create User
                        byte[] salt = PasswordUtilities.CreateSalt();
                        string hash = PasswordUtilities.CreateHash(tbPassword.Text);
                        _userId = Factory.createSKLUser(tbLogin.Text.Trim().ToUpper(), tbFirstName.Text.Trim(), tbLastName.Text.Trim(),
                            tbEmail.Text.Trim(), hash, salt, true, false, SKLUserType.AdminEcole, _username, DateTime.Now);

                        //Create the user Resource
                        long Id = Factory.createUserResource(_userId, (SKLResourceType)0, _ecoleId, false, _username, DateTime.Now);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur est déjà utilisé par quelqu'un d'autre");
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe non vérifié");
                }
            }
            else
            {
                MessageBox.Show("Entrez toutes les données");
            }
        }
    }
}
