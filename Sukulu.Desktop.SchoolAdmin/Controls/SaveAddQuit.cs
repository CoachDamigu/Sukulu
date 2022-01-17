using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class SaveAddQuit : UserControl
    {
        public EventHandler SaveQuitClicked;
        public EventHandler SaveAddClicked;
        public EventHandler QuitClicked;

        public SaveAddQuit()
        {
            InitializeComponent();
            AddToolTips();
        }

        public void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnSaveQuit, "Sauvegarder et quitter");
            toolTip.SetToolTip(btnSaveAdd, "Sauvegarder et en rajouter ");
            toolTip.SetToolTip(btnQuit, "Quitter");

        }

        private void btnSaveQuit_Click(object sender, EventArgs e)
        {
            if (SaveQuitClicked != null)
            {
                SaveQuitClicked(sender, e);
            }
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (SaveAddClicked != null)
            {
                SaveAddClicked(sender, e);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (QuitClicked != null)
            {
                QuitClicked(sender, e);
            }
        }
    }
}
