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
    public partial class CreateClasse : Form
    {
        SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();

        public CreateClasse()
        {
            InitializeComponent();

            //Fill Comboboxes of Systeme scolaire and Enseignement
            cbSystemeScolaire.Items.Add("Choisissez un système scolaire");
            //cbEnseignement.Items.Add("Choisissez un système scolaire");
            SystemeScolaireFactory Factory = new SystemeScolaireFactory();
            List<SystemeScolaire> ListSystemeScolaires = Factory.getAllSystemeScolaires();
            if (ListSystemeScolaires.Count > 0)
                foreach (SystemeScolaire ssco in ListSystemeScolaires)
                    cbSystemeScolaire.Items.Add(ssco);
            cbSystemeScolaire.SelectedIndex = 0;

            // Add footer control

            ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
            ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);
        }

        private void cbSystemeScolaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEnseignement.Items.Clear();
            cbEnseignement.Items.Add("Choisissez un enseignement");
            cbNiveau.Items.Clear();
            cbNiveau.Items.Add("Choisissez un niveau");
            cbSerie.Items.Clear();
            cbSerie.Items.Add("Choisissez une série");

            if (cbSystemeScolaire.SelectedIndex > 0)
            {
                // update Enseignement Combobox

                SystemeScolaire ssco = (SystemeScolaire)cbSystemeScolaire.SelectedItem;
                SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                List<Enseignement> ListEnseignements = Factory.getListEnseignementsFromSystemeScolaire(ssco.Id);
                if (ListEnseignements.Count > 0)
                    foreach (Enseignement ens in ListEnseignements)
                        cbEnseignement.Items.Add(ens);
                cbEnseignement.SelectedIndex = 0;
            }
            else
            {
                ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
                ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
            }
        }

        private void cbEnseignement_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNiveau.Items.Clear();
            cbNiveau.Items.Add("Choisissez un niveau");
            cbSerie.Items.Clear();
            cbSerie.Items.Add("Choisissez une série");
            if (cbEnseignement.SelectedIndex > 0)
            {
                Enseignement ens = (Enseignement)cbEnseignement.SelectedItem;
                SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                List<Niveau> ListNiveaux = Factory.getListNiveauxFromEnseignement(ens.Id);
                if (ListNiveaux.Count > 0)
                    foreach (Niveau niv in ListNiveaux)
                        cbNiveau.Items.Add(niv);
                cbNiveau.SelectedIndex = 0;

                List<Serie> ListSeries = Factory.getListSerieFromEnseignement(ens.Id);
                if (ListSeries.Count > 0)
                    foreach (Serie ser in ListSeries)
                        cbSerie.Items.Add(ser);
                cbSerie.SelectedIndex = 0;
            }
            else
            {
                ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
                ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
            }
        }

        private void cbNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNiveau.SelectedIndex > 0)
            {
                ctrlSaveAddQuit.btnSaveAdd.Enabled = true;
                ctrlSaveAddQuit.btnSaveQuit.Enabled = true;

            }
            else
            {
                ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
                ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
            }
        }

        private void cbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSerie.SelectedIndex > 0)
            {
                if (cbNiveau.SelectedIndex > 0)
                {
                    ctrlSaveAddQuit.btnSaveAdd.Enabled = true;
                    ctrlSaveAddQuit.btnSaveQuit.Enabled = true;
                }

            }
            //else
            //{
            //    ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
            //    ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
            //}
        }

        private void SaveRecord()
        {
            if (!string.IsNullOrEmpty(tbCode.Text) && !string.IsNullOrWhiteSpace(tbCode.Text) &&
                !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrWhiteSpace(tbName.Text) &&
                cbSystemeScolaire.SelectedIndex > 0 && cbEnseignement.SelectedIndex > 0 && cbNiveau.SelectedIndex > 0)
            {
                SystemeScolaireFactory Factory = new SystemeScolaireFactory();
                Niveau niv = (Niveau)cbNiveau.SelectedItem;
                if (cbSerie.SelectedIndex > 0)
                {
                    Serie ser = (Serie)cbSerie.SelectedItem;
                    long ClasseId = Factory.createClasse(niv.Id, ser.Id, tbCode.Text.Trim(), tbName.Text.Trim(), 
                        tbDescription.Text.Trim(), "SKLADMIN", DateTime.Today);
                }
                else
                {
                    long ClasseId = Factory.createClasse(niv.Id, null, tbCode.Text.Trim(), tbName.Text.Trim(),
                        tbDescription.Text.Trim(), "SKLADMIN", DateTime.Today);
                }
                Enseignement ens = (Enseignement)cbEnseignement.SelectedItem;
                long SerieId = Factory.createSerie(ens.Id, tbCode.Text.Trim(), tbName.Text.Trim(),
                    tbDescription.Text.Trim(), "SKLADMIN", DateTime.Today);
            }
            else
            {
                MessageBox.Show("Données manquantes");
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
            cbEnseignement.SelectedIndex = 0;
            tbCode.Text = null;
            tbName.Text = null;
            tbDescription.Text = null;
            //ctrlSaveAddQuit.btnSaveAdd.Enabled = false;
            //ctrlSaveAddQuit.btnSaveQuit.Enabled = false;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
