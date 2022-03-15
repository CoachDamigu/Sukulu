using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Forms
{
    public partial class SelectEnseignant : Form
    {
        public List<Enseignant> _ListEnseignants = new List<Enseignant>();
        List<Enseignant> ListEnseignantsToSearchFrom = new List<Enseignant>();
        long _anneeScolaireId;
        long _ecoleId;
        long _salleClasseId;

        public SelectEnseignant(long anneeScolaireId, long ecoleId, long salleClasseId, Boolean allowMultipleSelect)
        {
            _anneeScolaireId = anneeScolaireId;
            _ecoleId = ecoleId;
            _salleClasseId = salleClasseId;
            InitializeComponent();
            dgvEnseignants.MultiSelect = allowMultipleSelect;
            GetInitialElevesList();
        }

        private void LoadEnseignants(List<Enseignant> ListEnseignants)
        {
            dgvEnseignants.DataSource = null;

            if (ListEnseignants.Count > 0)
            {
                var source = new BindingSource();
                var Enseignants = from el in ListEnseignants
                             select new
                             {
                                 Id = el.Id,
                                 Matricule = el.Number,
                                 Nom = el.LastName,
                                 Prenom = el.FirstName,
                                 Email = el.Email,
                                 DateNaissance = el.DateOfBirth.ToShortDateString(),
                                 Phone = el.Phone
                             };
                dgvEnseignants.AutoGenerateColumns = true;
                source.DataSource = Enseignants;
                dgvEnseignants.DataSource = source;
                dgvEnseignants.Columns[0].Visible = false;
            }
        }

        private void GetInitialElevesList()
        {
            //EcoleFactory eFactory = new EcoleFactory();
            EnseignementFactory Factory = new EnseignementFactory();
            ListEnseignantsToSearchFrom = Factory.getAllEnseignants();
            if (_anneeScolaireId > 0 && _ecoleId > 0)
            {
                ListEnseignantsToSearchFrom = Factory.getAllEnseignantsFromEcoleAndAnneeScolaire(_ecoleId, _anneeScolaireId);
            }
            if (_salleClasseId > 0)
            {
                ListEnseignantsToSearchFrom = Factory.getAllEnseignantsFromSalleClasse(_salleClasseId);
            }

            LoadEnseignants(ListEnseignantsToSearchFrom);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)) &&
                 (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text)) &&
                 (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrWhiteSpace(tbEmail.Text)))
            {
                List<Enseignant> ListEnseignants = new List<Enseignant>();
                if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    ListEnseignants = ListEnseignantsToSearchFrom.FindAll(el => el.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    ListEnseignants = ListEnseignantsToSearchFrom.FindAll(el => el.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    ListEnseignants = ListEnseignantsToSearchFrom.FindAll(el => el.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                LoadEnseignants(ListEnseignants);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvEnseignants.SelectedRows.Count > 0)
            {
                EnseignementFactory Factory = new EnseignementFactory();
                List<Enseignant> ListEnseignants = new List<Enseignant>();
                foreach (DataGridViewRow row in dgvEnseignants.SelectedRows)
                {
                    long enseignantId = (long)row.Cells[0].Value;
                    Enseignant enseignant = Factory.getEnseignantById(enseignantId);
                    ListEnseignants.Add(enseignant);
                }
                _ListEnseignants = ListEnseignants;
            }
            else
            {
                MessageBox.Show("Aucun enseignant sélectionné");
            }
        }
    }
}
