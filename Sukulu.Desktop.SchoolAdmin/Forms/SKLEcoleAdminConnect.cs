using Microsoft.Data.SqlClient;
using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class SKLEcoleAdminConnect : Form
    {
        public Boolean connected = false;
        public string UserName;
        public SKLEcoleAdminConnect()
        {
            InitializeComponent();
            lblErrorMessage.Text = "";
            //long ecoleId = Properties.Settings.Default.EcoleName;
            //EcoleFactory Factory = new EcoleFactory();
            //Ecole ecole = Factory.getEcoleById(ecoleId);
            //tbLogin.Text = "SKLAdmin";
            //tbPassword.Text = "Sukulu2002!";

            //tbLogin.Text = "SKLParent";
            //tbPassword.Text = "Papa2022!";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            connected = false;
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
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
                        if ((int)user.UserType == 3)
                        {
                            // User is a SUKULU admin
                            connected = true;
                            UserName = tbLogin.Text.Trim();
                            Ecole ecole = umFactory.getSKLEcoleAdminResource(user.Id);
                            Properties.Settings.Default.EcoleId = ecole.Id;
                            Properties.Settings.Default.EcoleName = ecole.ShortName;
                            Sukulu.DataAccessLibrary.Global.UserID = tbLogin.Text.Trim();
                            Sukulu.DataAccessLibrary.Global.Password = tbPassword.Text;
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


            //try
            //{
            //    SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
            //    bldr.DataSource = Properties.Settings.Default.DataSource;
            //    bldr.InitialCatalog = Properties.Settings.Default.InitialCatalog;
            //    bldr.UserID = tbLogin.Text.Trim();
            //    bldr.Password = tbPassword.Text;
            //    bldr.ConnectTimeout = Properties.Settings.Default.ConnectTimeOut;
            //    bldr.Encrypt = Properties.Settings.Default.Encrypt;
            //    bldr.TrustServerCertificate = Properties.Settings.Default.TrustServerCertificate;
            //    bldr.ApplicationIntent = ApplicationIntent.ReadWrite;
            //    bldr.MultiSubnetFailover = Properties.Settings.Default.MultiSubnetFailover;

            //    using (SqlConnection mysqlConnection = new SqlConnection(bldr.ConnectionString))
            //    {
            //        mysqlConnection.Open();
            //    }
            //    Sukulu.DataAccessLibrary.Global.UserID = tbLogin.Text.Trim();
            //    Sukulu.DataAccessLibrary.Global.Password = tbPassword.Text;
            //    connected = true;
            //    UserName = tbLogin.Text.Trim();

            //    this.Close();
            //}
            //catch (SqlException ex)
            //{
            //    //lblErrorMessage.Text = ex.ToString();
            //    lblErrorMessage.Text = "Erreur de connection. Réessayez";
            //    connected = false;
            //}
        }
    }
}
