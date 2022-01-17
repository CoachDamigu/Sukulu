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
    public partial class EditSystemeScolaire : Form
    {
        string InitialName, InitialPrimaryOwner, InitialSecondaryOwner, InitialDescription, InitialNotes, InitialCountry;
        long _systemesScolaireId;
        public EditSystemeScolaire(long systemeScolaireId)
        {
            InitializeComponent();
            _systemesScolaireId = systemeScolaireId;
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            SystemeScolaire ssco = Factory.getSystemeScolaireById(systemeScolaireId);
            tbName.Text = InitialName = ssco.Name;
            tbPrimaryOwner.Text = InitialPrimaryOwner = ssco.PrimaryOwner;
            tbSecondaryOwner.Text = InitialSecondaryOwner = ssco.SecondaryOwner;
            tbDescription.Text = InitialDescription = ssco.Description;
            tbCountry.Text = InitialCountry = ssco.Country;
            tbNotes.Text = InitialNotes = ssco.Notes;

            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.btnSaveAdd.Visible = false;
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);

        }


        private void UpdateRecord()
        {
            if (InitialName.ToLower().Trim() == tbName.Text.ToLower().Trim() &&
                InitialPrimaryOwner.ToLower().Trim() == tbPrimaryOwner.Text.ToLower().Trim() &&
                InitialSecondaryOwner.ToLower().Trim() == tbSecondaryOwner.Text.ToLower().Trim() &&
                InitialDescription.ToLower().Trim() == tbDescription.Text.ToLower().Trim() &&
                InitialCountry.ToLower().Trim() == tbCountry.Text.ToLower().Trim() &&
                InitialNotes.ToLower().Trim() == tbNotes.Text.ToLower().Trim()
                )
            {
                MessageBox.Show("Rien à sauvegarder");
            }
            else
            {
                SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                Factory.updateSystemeScolaire(_systemesScolaireId, tbName.Text, tbPrimaryOwner.Text, tbSecondaryOwner.Text,
                    tbDescription.Text, tbCountry.Text, tbNotes.Text, "SKLADMIN", DateTime.Today);
                this.Close();
            }
        }

        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            UpdateRecord();
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            // just in case the Save and Add is triggered
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
