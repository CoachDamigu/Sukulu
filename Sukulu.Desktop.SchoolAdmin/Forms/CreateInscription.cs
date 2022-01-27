using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class CreateInscription : Form
    {
        Eleve _eleveSelect;
        long _anneeScolaireId, _ecoleId;
        string _userName;
        public CreateInscription(long ecoleId, long anneeScolaireId, string userName)
        {
            InitializeComponent();
            _anneeScolaireId = anneeScolaireId;
            _ecoleId = ecoleId;
            _userName = userName;
            EcoleFactory ecoleFactory = new EcoleFactory();
            lblInscriptionDate.Text = DateTime.Today.ToShortDateString();
            lblAnneeScolaire.Text = ecoleFactory.getAnneeScolaireById(_anneeScolaireId).ToString();

            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);

            LoadSalleClasses();
        }


        private void LoadSalleClasses()
        {
            cbSalleClasses.Items.Clear();
            EcoleFactory ecoleFactory = new EcoleFactory();
            cbSalleClasses.Items.Add("Choisissez une classe");
            List<SalleClasse> ListSalleClasses = ecoleFactory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId).OrderBy(sc => sc.Classe.Niveau.Ranking)
                .ThenBy(sc => sc.Code).ToList();
            foreach (SalleClasse sc in ListSalleClasses)
                cbSalleClasses.Items.Add(sc);
            cbSalleClasses.SelectedIndex = 0;
        }

        private void SaveRecord()
        {
            if (cbSalleClasses.SelectedIndex == 0 || _eleveSelect == null)
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                long salleClasseId = ((SalleClasse)cbSalleClasses.SelectedItem).Id;

                EcoleFactory ecoleFactory = new EcoleFactory();
                long InscriptionId = ecoleFactory.CreateInscription(_eleveSelect.Id, salleClasseId, DateTime.Today, tbNotes.Text.Trim(), _userName.ToUpper(), DateTime.Today);
            }

        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbMatricule.Text) || string.IsNullOrEmpty(tbMatricule.Text))
            {
                MessageBox.Show("Entrez un matricule avant vérification");
            }
            else
            {
                EcoleFactory ecoleFactory = new EcoleFactory();
                _eleveSelect = ecoleFactory.getEleveFromMatricule(tbMatricule.Text.Trim().ToUpper());
                if (_eleveSelect != null)
                {
                    lblEleve.Text = _eleveSelect.ToString();
                }
                else
                {
                    MessageBox.Show("Matricule inexistant. Réessayez");
                    lblEleve.Text = "";
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
            LoadSalleClasses();
            tbNotes.Text = null;
            lblInscriptionDate.Text = DateTime.Today.ToShortDateString();
            tbMatricule.Text = null;
            lblEleve.Text = null;
        }

        private void btnSelectEleve_Click(object sender, EventArgs e)
        {
            SelectEleve form = new SelectEleve();
            form.ShowDialog();
            if (form._selectedEleve != null)
            {
                _eleveSelect = form._selectedEleve;
                lblEleve.Text = _eleveSelect.ToString();
                
            }
            else
            {
                lblEleve.Text = "";
                _eleveSelect = null;
            }
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
