using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SKLAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Forms
{
    public partial class SystemeScolaireDetails : Form
    {
        public SystemeScolaireDetails(long systemeScolaireId)
        {
            InitializeComponent();
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            SystemeScolaire ssco = Factory.getSystemeScolaireById(systemeScolaireId);
            lblName.Text = ssco.Name;
            lblPrimaryOwner.Text = ssco.PrimaryOwner;
            lblSecondaryOwner.Text = ssco.SecondaryOwner;
            lblDescription.Text = ssco.Description;
            lblCountry.Text = ssco.Country;
            lblNotes.Text = ssco.Notes;

            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.btnSaveAdd.Visible = false;
            ctrlSaveAddQuit.btnSaveQuit.Visible = false;
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);
        }


        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            // just in case the Save and Add is triggered
            this.Close();
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
