using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class CreateSalleClasse : Form
    {
        long _ecoleId, _anneeScolaireId;
        public CreateSalleClasse(long ecoleId, long anneeScolaireId)
        {
            InitializeComponent();
            _ecoleId = ecoleId;
            _anneeScolaireId = anneeScolaireId;
            EcoleFactory ecoleFactory = new EcoleFactory();
            SystemeScolaireFactory systemeScolaireFactory = new SystemeScolaireFactory();
            Ecole ecole = ecoleFactory.getEcoleById(_ecoleId);
            cbClasses.Items.Add("Sélectionner une classe");
            List<Classe> ListClasses= systemeScolaireFactory.getClassesFromSystemeScolaire(ecole.SystemeScolaireId);
            if (ListClasses.Count > 0)
                foreach (Classe ec in ListClasses)
                    cbClasses.Items.Add(ec);
            cbClasses.SelectedIndex = 0;

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
                if (cbClasses.SelectedIndex > 0)
                {
                    Classe cl = (Classe)cbClasses.SelectedItem;
                    EcoleFactory ecoleFactory = new EcoleFactory();
                    long salleClasseId = ecoleFactory.CreateSalleClasse(tbCode.Text.Trim(), tbName.Text.Trim(), tbDescription.Text.Trim(),
                        _anneeScolaireId, cl.Id, _ecoleId, "SKLADMIN", DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Il faut sélectionner une classe");
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
            cbClasses.SelectedIndex = 0;
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
