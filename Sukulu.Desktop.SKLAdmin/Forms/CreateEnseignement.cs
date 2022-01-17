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
    public partial class CreateEnseignement : Form
    {
        public CreateEnseignement()
        {
            InitializeComponent();
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            cbSystemeScolaire.Items.Add("Sélectionner un système scolaire");
            List<SystemeScolaire> ListSystemeScolaires = Factory.getAllSystemeScolaires();
            if (ListSystemeScolaires.Count > 0)
                foreach (SystemeScolaire ssco in ListSystemeScolaires)
                    cbSystemeScolaire.Items.Add(ssco);
            cbSystemeScolaire.SelectedIndex = 0;

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
            if (string.IsNullOrEmpty(tbCode.Text) || string.IsNullOrWhiteSpace(tbCode.Text) ||
                string.IsNullOrEmpty(tbName.Text) || string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                if (cbSystemeScolaire.SelectedIndex > 0)
                {
                    SystemeScolaire ssco = (SystemeScolaire)cbSystemeScolaire.SelectedItem;
                    SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                    Factory.createEnseignement(tbCode.Text.Trim(), tbName.Text.Trim(), tbDescription.Text.Trim(), ssco.Id, "SKLADMIN", DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Il faut sélectionner un système scolaire");
                }
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
            cbSystemeScolaire.SelectedIndex = 0;
            tbCode.Text = null;
            tbName.Text = null;
            tbDescription.Text = null;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
