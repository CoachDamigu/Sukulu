using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SKLAdmin.Controls;
using Sukulu.Desktop.SKLAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin
{
    public partial class SKLAdminStart : Form
    {
        string _userName;
        Boolean _connected = false;
        public SKLAdminStart()
        {
            
            
            InitializeComponent();
            tsmiSukuluSystemeScolaire.Visible = false;
            tsmiEcoles.Visible = false;
            tsmiUtilisateurs.Visible = false;

        }

        private void tsmiSukuluSystemeScolaire_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMenu.Visible = false; /// hiding the menu
            SystemeScolaireActions ctrlSystemeScolaireActions = new SystemeScolaireActions();
            pnlBody.Controls.Clear();
            ctrlSystemeScolaireActions.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ctrlSystemeScolaireActions);
            Cursor.Current = Cursors.Default;
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiUtilisateurs_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMenu.Visible = false; /// hiding the menu
            //UtilisateursActions control = new UtilisateursActions(_userName);
            ClientsEcoleUtilisateursResourcesActions control = new ClientsEcoleUtilisateursResourcesActions(_userName);
            pnlBody.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(control);
            Cursor.Current = Cursors.Default;
        }

        private void tsmiConnectDeconnect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                // Not connected
                SKLAdminConnect form = new SKLAdminConnect();
                form.ShowDialog();
                if (form.connected)
                {
                    tsmiConnectDeconnect.Text = "Se déconnecter";
                    tsmiSukuluSystemeScolaire.Visible = true;
                    tsmiEcoles.Visible = true;
                    tsmiUtilisateurs.Visible = true;
                    _connected = form.connected;

                    
                    UserManagementFactory umFactory = new UserManagementFactory();
                    _userName = form.UserName;
                    //Sukulu.DataAccessLibrary.Global.Password = umFactory.getUserHash(_userName);

                    //Sukulu.DataAccessLibrary.Global.UserID = "SKLAdmin";
                    

                    lblConnected.Text = "Vous êtes connecté : " + form.UserName.ToUpper();
                }
                else
                {
                    tsmiConnectDeconnect.Text = "Se connecter";
                    tsmiSukuluSystemeScolaire.Visible = false;
                    tsmiEcoles.Visible = false;
                    tsmiUtilisateurs.Visible = false;
                    _connected = form.connected;
                    _userName = null;
                    lblConnected.Text = "Vous n'êtes pas connecté...";

                    Sukulu.DataAccessLibrary.Global.UserID = null;
                    _userName = null;
                    Sukulu.DataAccessLibrary.Global.Password = null;
                }
            }
            else
            {
                tsmiConnectDeconnect.Text = "Se connecter";
                tsmiSukuluSystemeScolaire.Visible = false;
                tsmiEcoles.Visible = false;
                tsmiUtilisateurs.Visible = false;
                _connected = false;
                _userName = null;
                lblConnected.Text = "Vous n'êtes pas connecté...";

                Sukulu.DataAccessLibrary.Global.UserID = null;
                _userName = null;
                Sukulu.DataAccessLibrary.Global.Password = null;
            }
        }
    }
}
