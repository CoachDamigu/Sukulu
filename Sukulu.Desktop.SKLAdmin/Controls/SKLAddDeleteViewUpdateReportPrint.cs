using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SKLAdmin.Controls
{
    public partial class SKLAddDeleteViewUpdateReportPrint : UserControl
    {
        public EventHandler AddClicked;
        public EventHandler DeleteClicked;
        public EventHandler ViewClicked;
        public EventHandler UpdateClicked;
        public EventHandler ReportClicked;
        public EventHandler PrintClicked;
        public SKLAddDeleteViewUpdateReportPrint()
        {
            InitializeComponent();
            AddToolTips();
        }
        public SKLAddDeleteViewUpdateReportPrint(Boolean vAdd, Boolean vDelete, Boolean vView, Boolean vUpdate, Boolean vReport, Boolean vPrint)
        {
            InitializeComponent();
            btnAdd.Visible = vAdd;
            btnView.Visible = vView;
            btnDelete.Visible = vDelete;
            btnUpdate.Visible = vUpdate;
            btnReport.Visible = vReport;
            btnPrint.Visible = vPrint;
            AddToolTips();
        }


        public void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnAdd, "Ajouter ");
            toolTip.SetToolTip(btnDelete, "Supprimer ");
            toolTip.SetToolTip(btnView, "Détails ");
            toolTip.SetToolTip(btnUpdate, "Metter à jour ");
            toolTip.SetToolTip(btnReport, "Rapport ");
            toolTip.SetToolTip(btnPrint, "Imprimer ");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddClicked != null)
            {
                AddClicked(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteClicked != null)
            {
                DeleteClicked(sender, e);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (ViewClicked != null)
            {
                ViewClicked(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateClicked != null)
            {
                UpdateClicked(sender, e);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (ReportClicked != null)
            {
                ReportClicked(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (PrintClicked != null)
            {
                PrintClicked(sender, e);
            }
        }
    }
}
