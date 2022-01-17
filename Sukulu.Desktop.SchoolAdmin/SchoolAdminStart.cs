using Sukulu.Desktop.SchoolAdmin.Controls;
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
        public SchoolAdminStart()
        {
            InitializeComponent();
        }

        private void tsmiEcole_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMenu.Visible = false; /// hiding the menu
            //get Ecole and Annee scolaire from a setting repository ---
            EcoleActions ctrlSystemeScolaireActions = new EcoleActions(4,1);
            pnlBody.Controls.Clear();
            ctrlSystemeScolaireActions.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ctrlSystemeScolaireActions);
            Cursor.Current = Cursors.Default;
        }

        private void tsmiQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
