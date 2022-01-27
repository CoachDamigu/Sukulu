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

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    
    public partial class SelectEleve : Form
    {
        public Eleve _selectedEleve;

        public SelectEleve()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ( (string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)) &&
                 (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text)) &&
                 (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrWhiteSpace(tbEmail.Text)) )
            {
                MessageBox.Show("Enterz au moin un critère");
            }
            else
            {
                EcoleFactory Factory = new EcoleFactory();
                List<Eleve> ListEleves = Factory.getAllEleves();

                if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    ListEleves = ListEleves.FindAll(el => el.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
                {
                    ListEleves = ListEleves.FindAll(el => el.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    ListEleves = ListEleves.FindAll(el => el.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                }


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
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvEleves.SelectedRows.Count == 1)
            {
                long eleveId = (long)dgvEleves.SelectedRows[0].Cells[0].Value;
                EcoleFactory Factory = new EcoleFactory();
                _selectedEleve = Factory.getEleveById(eleveId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sélection un élève");
                _selectedEleve = null;
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
