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
    public partial class CreateSystemeScolaire : Form
    {
        public CreateSystemeScolaire()
        {
            InitializeComponent();

            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);
        }


        private void SaveRecord()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbPrimaryOwner.Text))
            {
                MessageBox.Show("Il manque des données");
            }
            else
            {
                SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                long Id = Factory.createSystemeScolaire(tbName.Text.Trim(), tbPrimaryOwner.Text.Trim(), tbSecondaryOwner.Text.Trim(),
                    tbDescription.Text.Trim(), tbCountry.Text.Trim(), tbNotes.Text.Trim(), "SKLADMIN", DateTime.Today);
            }
        }
        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            SaveRecord();
            tbName.Text = null;
            tbPrimaryOwner.Text = null;
            tbSecondaryOwner.Text = null;
            tbDescription.Text = null;
            tbCountry.Text = null;
            tbNotes.Text = null;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void Quitter_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnValidate_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbPrimaryOwner.Text))
        //    {
        //        MessageBox.Show("Il manque des données");
        //    }
        //    else
        //    {
        //        SystemeScolaireFactory Factory = new SystemeScolaireFactory();
        //        long Id = Factory.createSystemeScolaire(tbName.Text.Trim(), tbPrimaryOwner.Text.Trim(), tbSecondaryOwner.Text.Trim(),
        //            tbDescription.Text.Trim(), tbCountry.Text.Trim(), tbNotes.Text.Trim(), "SKLADMIN", DateTime.Today);
        //        this.Close();
        //    }
        //}
    }
}
