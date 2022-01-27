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
    public partial class CreateSalleClasseMatiere : Form
    {
        long _salleClasseId;
        string _userName;
        public CreateSalleClasseMatiere(long salleClasseId, string userName)
        {
            _salleClasseId = salleClasseId;
            _userName = userName;
            InitializeComponent();
            LoadMatieres();
            nudCoefficient.DecimalPlaces = 1;
            nudCoefficient.Increment = 0.5M;
            EcoleFactory Factory = new EcoleFactory();
            lblSalleClasse.Text = Factory.getSalleClasseById(_salleClasseId).Name;
            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);
        }

        public void LoadMatieres()
        {
            cbMatieres.Items.Clear();
            cbMatieres.Items.Add("Choisissez une matière");
            EnseignementFactory Factory = new EnseignementFactory();
            List<Matiere> ListMatieres = Factory.getMatieresNotInSalleClasseMatiere(_salleClasseId);
            if (ListMatieres.Count > 0)
                foreach (Matiere m in ListMatieres)
                    cbMatieres.Items.Add(m);
            cbMatieres.SelectedIndex = 0;
        }

        private void SaveRecord()
        {
            if (cbMatieres.SelectedIndex > 0 && nudCoefficient.Value > 0)
            {
                long matiereId = ((Matiere)cbMatieres.SelectedItem).Id;
                Double coefficient = (Double)nudCoefficient.Value;
                EnseignementFactory Factory = new EnseignementFactory();
                long Id = Factory.createSalleClasseMatiere(matiereId, _salleClasseId, tbNotes.Text.Trim(), coefficient, _userName, DateTime.Now);
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
            LoadMatieres();
            tbNotes.Text = null;
            nudCoefficient.Value = 1;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
