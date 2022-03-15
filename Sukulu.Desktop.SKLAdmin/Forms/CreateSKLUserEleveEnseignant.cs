using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Forms
{
    public partial class CreateSKLUserEleveEnseignant : Form
    {
        string _username;
        SKLUserType _userType;
        public long _userId;
        SKLTypePerson _typePerson;
        public Eleve _eleve;
        public Enseignant _enseignant;
        public CreateSKLUserEleveEnseignant(string userName, SKLUserType userType)
        {
            _username = userName;
            _userType = userType;
            InitializeComponent();
            ChangeSelectButton();
        }


        private void ChangeSelectButton()
        {
            if (_userType != SKLUserType.Eleve && _userType != SKLUserType.Enseignant)
            {
                btnSelectEleveOrEnseignant.Visible = false;
                
            }
            else
            {
                btnSelectEleveOrEnseignant.Visible = true;
                if (_userType == SKLUserType.Eleve)
                {
                    btnSelectEleveOrEnseignant.Text = "Sélectionner l'élève";
                    _typePerson = SKLTypePerson.Eleve;
                }
                else
                {
                    btnSelectEleveOrEnseignant.Text = "Sélectionner l'enseignant";
                    _typePerson = SKLTypePerson.Enseignant;
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserManagementFactory Factory = new UserManagementFactory();
            if ( (_eleve != null || _enseignant != null) &&
                (!string.IsNullOrEmpty(tbLogin.Text) && (!string.IsNullOrWhiteSpace(tbLogin.Text))) &&
                (!string.IsNullOrEmpty(tbPassword.Text) && (!string.IsNullOrWhiteSpace(tbPassword.Text))) &&
                (!string.IsNullOrEmpty(tbVerifyPassword.Text) && (!string.IsNullOrWhiteSpace(tbVerifyPassword.Text))))
            {
                if (string.Compare(tbPassword.Text, tbVerifyPassword.Text) == 0)
                {
                    
                    Boolean isLoginUsed = Factory.isLoginExist(tbLogin.Text);

                    if (!isLoginUsed)
                    {
                        //Create User
                        string FirstName = (_eleve == null) ? (_enseignant.FirstName) : (_eleve.FirstName);
                        string LastName = (_eleve == null) ? (_enseignant.LastName) : (_eleve.LastName);
                        string Email = (_eleve == null) ? (_enseignant.Email) : (_eleve.Email);
                        byte[] salt = PasswordUtilities.CreateSalt();
                        string hash = PasswordUtilities.CreateHash(tbPassword.Text);
                        _userId = Factory.createSKLUser(tbLogin.Text.Trim().ToUpper(), FirstName, LastName,
                            Email, hash, salt, true, false, _userType, _username, DateTime.Now);

                        //If the user is a student add him or her to his or her resources

                        if (_eleve != null)
                        {
                            long id = Factory.createUserResource(_userId, SKLResourceType.Eleve, _eleve.Id, false, _username, DateTime.Now);
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur est déjà utilisé par quelqu'un d'autre");
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe non vérifié");
                }
            }
            else
            {
                MessageBox.Show("Entrez toutes les données");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectEleveOrEnseignant_Click(object sender, EventArgs e)
        {
            SelectPerson form = new SelectPerson(_typePerson);
            form.ShowDialog();
            long personId = form._selectedPersonId;
            //_eleve = form._selectedEleve;
            if (personId > 0)
            {
                if (_typePerson == SKLTypePerson.Eleve)
                {
                    EcoleFactory factory = new EcoleFactory();
                    Eleve eleve = factory.getEleveById(personId);
                    _eleve = eleve;
                    lblLastName.Text = eleve.LastName;
                    lblFirstName.Text = eleve.FirstName;
                    lblEmail.Text = eleve.Email;
                }

                if (_typePerson == SKLTypePerson.Enseignant)
                {
                    EnseignementFactory factory = new EnseignementFactory();
                    Enseignant enseignant = factory.getEnseignantById(personId);
                    _enseignant = enseignant;
                    lblLastName.Text = enseignant.LastName;
                    lblFirstName.Text = enseignant.FirstName;
                    lblEmail.Text = enseignant.Email;
                }

            }
        }
    }
}
