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
    public partial class SukuluConnect : Form
    {
        public Boolean connected = false;
        public string UserName;
        public SukuluConnect()
        {
            InitializeComponent();
            lblErrorMessage.Text = "";
            //long ecoleId = Properties.Settings.Default.EcoleName;
            //EcoleFactory Factory = new EcoleFactory();
            //Ecole ecole = Factory.getEcoleById(ecoleId);
            lblEcole.Text = Properties.Settings.Default.EcoleName;
            tbLogin.Text = "SKLAdmin";
            tbPassword.Text = "Sukulu2002!";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            connected = false;
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
                bldr.DataSource = Properties.Settings.Default.DataSource;
                bldr.InitialCatalog = Properties.Settings.Default.InitialCatalog;
                bldr.UserID = tbLogin.Text.Trim();
                bldr.Password = tbPassword.Text;
                bldr.ConnectTimeout = Properties.Settings.Default.ConnectTimeOut;
                bldr.Encrypt = Properties.Settings.Default.Encrypt;
                bldr.TrustServerCertificate = Properties.Settings.Default.TrustServerCertificate;
                bldr.ApplicationIntent = ApplicationIntent.ReadWrite;
                bldr.MultiSubnetFailover = Properties.Settings.Default.MultiSubnetFailover;

                using (SqlConnection mysqlConnection = new SqlConnection(bldr.ConnectionString))
                {
                    mysqlConnection.Open();
                }
                Sukulu.DataAccessLibrary.Global.UserID = tbLogin.Text.Trim();
                Sukulu.DataAccessLibrary.Global.Password = tbPassword.Text;
                connected = true;
                UserName = tbLogin.Text.Trim();

                this.Close();
            }
            catch (SqlException ex)
            {
                //lblErrorMessage.Text = ex.ToString();
                lblErrorMessage.Text = "Erreur de connection. Réessayez";
                connected = false;
            }
        }
    }
}
