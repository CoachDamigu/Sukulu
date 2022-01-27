using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using Sukulu.Desktop.SchoolAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin
{
    public partial class SchoolAdminStart : Form
    {
        Boolean _connected = false;
        string _username;
        long _ecoleId;
        long _anneeScolaireId;
        public SchoolAdminStart()
        {
            InitializeComponent();
            tsmiEcole.Visible = false;
            tsmiEmploiDuTemps.Visible = false;
            tsmiEnseignement.Visible = false;
            _ecoleId = Properties.Settings.Default.EcoleId;
            _anneeScolaireId = Properties.Settings.Default.AnneeScolaireId;
        }

        private void tsmiEcole_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMenu.Visible = false; /// hiding the menu
            //get Ecole and Annee scolaire from a setting repository ---
            EcoleActions ctrlSystemeScolaireActions = new EcoleActions(_ecoleId, _anneeScolaireId, _username);
            pnlBody.Controls.Clear();
            ctrlSystemeScolaireActions.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ctrlSystemeScolaireActions);
            Cursor.Current = Cursors.Default;
        }

        private void tsmiEnseignement_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMenu.Visible = false; /// hiding the menu
            //get Ecole and Annee scolaire from a setting repository ---
            EnseignementActions ctrlEnseignementActions = new EnseignementActions(_ecoleId, _anneeScolaireId, _username);
            pnlBody.Controls.Clear();
            ctrlEnseignementActions.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ctrlEnseignementActions);
            Cursor.Current = Cursors.Default;
        }
        

        private void tsmiEmploiDuTemps_Click(object sender, EventArgs e)
        {
            //SelectSalleClasse form = new SelectSalleClasse(_ecoleId, _anneeScolaireId, false);
            //form.ShowDialog();
            //if (form._salleClassesSelected.Count == 1)
            //{
                Cursor.Current = Cursors.WaitCursor;
                pnlMenu.Visible = false; /// hiding the menu
                EmploiDuTemps ctrlEmploiDuTemps = new EmploiDuTemps(_ecoleId, _anneeScolaireId,  DateTime.Today, _username);
                pnlBody.Controls.Clear();
                ctrlEmploiDuTemps.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(ctrlEmploiDuTemps);
                Cursor.Current = Cursors.Default;
            //}
        }

        private void tsmiQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiConnectDeconnect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                // Not connected
                SukuluConnect form = new SukuluConnect();
                form.ShowDialog();
                if (form.connected)
                {
                    tsmiConnectDeconnect.Text = "Se déconnecter";
                    tsmiEcole.Visible = true;
                    tsmiEmploiDuTemps.Visible = true;
                    tsmiEnseignement.Visible = true;
                    _connected = form.connected;
                    lblConnected.Text = "Vous êtes connecté : " + form.UserName.ToUpper();
                    _username = form.UserName;
                    EcoleFactory Factory = new EcoleFactory();
                    Ecole ecole = Factory.getEcoleById(_ecoleId);
                    AnneeScolaire anneeScolaire = Factory.getAnneeScolaireById(_anneeScolaireId);
                    lblEcoleAnneeScolaire.Text = ecole.ShortName + " [ " + anneeScolaire.ToString() + " ]";
                }
                else
                {
                    tsmiConnectDeconnect.Text = "Se connecter";
                    tsmiEcole.Visible = false;
                    tsmiEmploiDuTemps.Visible = false;
                    tsmiEnseignement.Visible = false;
                    _connected = form.connected;
                    _username = null;
                    lblConnected.Text = "Vous n'êtes pas connecté...";
                    lblEcoleAnneeScolaire.Text = "";
                }
            }
            else
            {
                tsmiConnectDeconnect.Text = "Se connecter";
                tsmiEcole.Visible = false;
                tsmiEmploiDuTemps.Visible = false;
                tsmiEnseignement.Visible = false;
                _connected = false;
                _username = null;
                lblConnected.Text = "Vous n'êtes pas connecté...";
                lblEcoleAnneeScolaire.Text = "";
            }
        }
    }
}
