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
    public partial class SelectEleves : Form
    {
        public List<Eleve> _ListEleves = new List<Eleve>();
        List<Eleve> ListElevesToSearchFrom = new List<Eleve>();
        long _anneeScolaireId;
        long _ecoleId;
        long _salleClasseId;
        public SelectEleves(long anneeScolaireId, long ecoleId, long salleClasseId, Boolean allowMultipleSelect)
        {
            _anneeScolaireId = anneeScolaireId;
            _ecoleId = ecoleId;
            _salleClasseId = salleClasseId;
            InitializeComponent();
            dgvEleves.MultiSelect = allowMultipleSelect;
            GetInitialElevesList();
        }

        private void GetInitialElevesList()
        {
            EcoleFactory Factory = new EcoleFactory();
            ListElevesToSearchFrom = Factory.getAllEleves();
            if (_anneeScolaireId > 0)
            {
                ListElevesToSearchFrom = Factory.getAllElevesFromAnneeScolaire(_anneeScolaireId);

                if (_ecoleId > 0)
                {
                    ListElevesToSearchFrom = Factory.getAllElevesFromEcoleAndAnneeScolaire(_ecoleId, _anneeScolaireId);
                }
            }
            if (_salleClasseId > 0)
            {
                ListElevesToSearchFrom = Factory.getElevesFromSalleClasse(_salleClasseId);
            }

            LoadEleves(ListElevesToSearchFrom);
        }

        private void LoadEleves(List<Eleve> ListEleves)
        {
            dgvEleves.DataSource = null;

            if (ListEleves.Count > 0)
            {
                var source = new BindingSource();
                var Eleves = from el in ListEleves
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
                dgvEleves.AutoGenerateColumns = true;
                source.DataSource = Eleves;
                dgvEleves.DataSource = source;
                dgvEleves.Columns[0].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)) &&
                 (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text)) &&
                 (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrWhiteSpace(tbEmail.Text)))
            {
                List<Eleve> ListEleves = new List<Eleve>();
                if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    ListEleves = ListElevesToSearchFrom.FindAll(el => el.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    ListEleves = ListElevesToSearchFrom.FindAll(el => el.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    ListEleves = ListElevesToSearchFrom.FindAll(el => el.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                LoadEleves(ListEleves);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvEleves.SelectedRows.Count > 0)
            {
                EcoleFactory Factory = new EcoleFactory();
                List<Eleve> ListEleves = new List<Eleve>();
                foreach(DataGridViewRow row in dgvEleves.SelectedRows)
                {
                    long eleveId = (long)row.Cells[0].Value;
                    Eleve eleve = Factory.getEleveById(eleveId);
                    ListEleves.Add(eleve);
                }
                _ListEleves = ListEleves;
            }
            else
            {
                MessageBox.Show("Aucun élève sélectionné");
            }
        }
    }
}
