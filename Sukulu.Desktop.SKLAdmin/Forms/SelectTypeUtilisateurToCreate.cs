using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Forms
{
    public partial class SelectTypeUtilisateurToCreate : Form
    {
        public SKLUserType _userType = new SKLUserType();
        public Boolean _isUserTypeSelected = false;
        public SelectTypeUtilisateurToCreate()
        {
            InitializeComponent();
            btnSelect.Enabled = false;
            cbTypeUtilisateur.Items.Add("Type d'utilisateur");
            Array userTypes = Enum.GetValues(typeof(SKLUserType));
            foreach (SKLUserType userType in userTypes)
            {
                if (userType != SKLUserType.AdminSKL)
                    cbTypeUtilisateur.Items.Add(userType.GetDisplayName());
            }
            cbTypeUtilisateur.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbTypeUtilisateur.SelectedIndex > 0)
            {
                _userType = (SKLUserType)(cbTypeUtilisateur.SelectedIndex-1);
                this.Close();
            }
        }

        private void cbTypeUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeUtilisateur.SelectedIndex > 0)
            {
                btnSelect.Enabled = true;
                _isUserTypeSelected = true;
                _userType = (SKLUserType)(cbTypeUtilisateur.SelectedIndex-1);
            }
            else
            {
                btnSelect.Enabled = false;
                _isUserTypeSelected = false;
            }
        }
    }
}
