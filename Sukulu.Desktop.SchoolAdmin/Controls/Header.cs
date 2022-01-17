using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class Header : UserControl
    {
        public EventHandler CloseClicked;
        public Header(string Header)
        {
            InitializeComponent();
            lblHeader.Text = Header;
            ToolTip toolTip = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btnClose, "Fermer");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseClicked != null)
            {
                CloseClicked(sender, e);
            }
        }
    }
}
