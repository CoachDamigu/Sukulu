using Sukulu.DataAccessLibrary.Enums;
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
    public partial class SelectPerson : Form
    {
        public Eleve _selectedEleve;
        public long _selectedPersonId = 0;
        public SKLTypePerson _typePerson;

        public SelectPerson(SKLTypePerson typePerson)
        {
            _typePerson = typePerson;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)) &&
                 (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text)) &&
                 (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrWhiteSpace(tbEmail.Text)))
            {
                MessageBox.Show("Entrez au moin un critère");
            }
            else
            {
                //List<Object> ListPersons = new List<object>();

                dgvPersons.DataSource = null;

                EcoleFactory ecFactory = new EcoleFactory();
                EnseignementFactory ensFactory = new EnseignementFactory();
                UserManagementFactory umFactory = new UserManagementFactory();

                List<Eleve> ListEleves = new List<Eleve>();
                List<Enseignant> ListEnseignants = new List<Enseignant>();
                List<SKLUser> ListUsers = new List<SKLUser>();
                if (_typePerson == SKLTypePerson.Eleve)
                {
                    ListEleves = ecFactory.getAllEleves();

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
                        dgvPersons.AutoGenerateColumns = true;
                        source.DataSource = Eleves;
                        dgvPersons.DataSource = source;
                        dgvPersons.Columns[0].Visible = false;
                    }
                }

                if (_typePerson == SKLTypePerson.Enseignant)
                {
                    ListEnseignants = ensFactory.getAllEnseignants();

                    if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
                    {
                        ListEnseignants = ListEnseignants.FindAll(el => el.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

                    if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
                    {
                        ListEnseignants = ListEnseignants.FindAll(el => el.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

                    if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
                    {
                        ListEnseignants = ListEnseignants.FindAll(el => el.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

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
                        dgvPersons.AutoGenerateColumns = true;
                        source.DataSource = Enseignants;
                        dgvPersons.DataSource = source;
                        dgvPersons.Columns[0].Visible = false;
                    }
                }

                if (_typePerson == SKLTypePerson.Utilisateur)
                {
                    ListUsers = umFactory.getAllUsers();

                    if (!string.IsNullOrEmpty(tbLastName.Text) || !string.IsNullOrWhiteSpace(tbLastName.Text))
                    {
                        ListUsers = ListUsers.FindAll(el => el.LastName.Contains(tbLastName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

                    if (!string.IsNullOrEmpty(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbFirstName.Text))
                    {
                        ListUsers = ListUsers.FindAll(el => el.FirstName.Contains(tbFirstName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

                    if (!string.IsNullOrEmpty(tbEmail.Text) || !string.IsNullOrWhiteSpace(tbEmail.Text))
                    {
                        ListUsers = ListUsers.FindAll(el => el.Email.Contains(tbEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                    }

                    if (ListUsers.Count > 0)
                    {
                        var source = new BindingSource();
                        var Users = from el in ListUsers
                                          select new
                                          {
                                              Id = el.Id,
                                              Login = el.Login,
                                              Nom = el.LastName,
                                              Prenom = el.FirstName,
                                              Email = el.Email
                                              //,
                                              //DateNaissance = el.DateOfBirth.ToShortDateString(),
                                              //Phone = el.Phone
                                          };
                        dgvPersons.AutoGenerateColumns = true;
                        source.DataSource = Users;
                        dgvPersons.DataSource = source;
                        dgvPersons.Columns[0].Visible = false;
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvPersons.SelectedRows.Count == 1)
            {
                long _selectedPersonId = (long)dgvPersons.SelectedRows[0].Cells[0].Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sélectionne un élève");
                _selectedEleve = null;
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
