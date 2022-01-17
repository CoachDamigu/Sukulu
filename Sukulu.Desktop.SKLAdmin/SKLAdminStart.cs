using Sukulu.Desktop.SKLAdmin.Controls;
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
        public SKLAdminStart()
        {
            InitializeComponent();
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
    }
}
