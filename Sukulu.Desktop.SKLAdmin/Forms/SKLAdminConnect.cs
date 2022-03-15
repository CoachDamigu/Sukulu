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
    public partial class SKLAdminConnect : Form
    {
        public Boolean connected = false;
        public string UserName;
        public SKLAdminConnect()
        {
            Sukulu.DataAccessLibrary.Global.UserID = "SKLUserChecker";
            Sukulu.DataAccessLibrary.Global.Password = "D-0562790jkghjg$lkefh";
            InitializeComponent();
            lblErrorMessage.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            connected = false;
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrWhiteSpace(tbLogin.Text) &&
                     !string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    UserManagementFactory umFactory = new UserManagementFactory();
                    SKLUser user = umFactory.getUserFromLogin(tbLogin.Text.Trim());
                    if (user != null)
                    {
                        if (PasswordUtilities.ValidatePassword(tbPassword.Text, user.PasswordHashed))
                        {
                            if ((int)user.UserType == 4)
                            {
                                // User is a SUKULU admin
                                connected = true;
                                UserName = tbLogin.Text.Trim();
                                Sukulu.DataAccessLibrary.Global.UserID = "SKLADMIN";
                                Sukulu.DataAccessLibrary.Global.Password = "Sukulu2002!";
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Vous n'êtes pas autorisé(e) ici.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mauvais nom d'utilisateur et ou/ mot de passe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mauvais nom d'utilisateur et ou/ mot de passe");
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe manquant(s)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mauvais nom d'utilisateur et ou/ mot de passe");
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
