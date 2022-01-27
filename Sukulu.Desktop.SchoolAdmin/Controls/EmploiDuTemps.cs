using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class EmploiDuTemps : UserControl
    {
        long _ecoleId;
        DateTime _firstDay;
        string _userName;
        long _anneeScolaireId;
        Header _header;
        public EmploiDuTemps(long ecoleId, long anneeScolaireId, DateTime? today, string userName)
        {
            InitializeComponent();
            _ecoleId = ecoleId;
            _userName = userName;
            _anneeScolaireId = anneeScolaireId;
            DateTimeFactory dateFactory = new DateTimeFactory();
            EcoleFactory ecoleFactory = new EcoleFactory();
            //SalleClasse salleClasse = ecoleFactory.getSalleClasseById(_salleClasseId);
            if (today == null) _firstDay = dateFactory.GetWeekFirstDateFromADate(DateTime.Today);
            else _firstDay = dateFactory.GetWeekFirstDateFromADate((DateTime)today);
            AddControls();
            LoadSalleClasses();
            //LoadEmploiDuTemps();
            //LoadSalleClasses();
        }

        private void LoadSalleClasses()
        {
            cbSalleClasse.Items.Clear();
            cbSalleClasse.Items.Add("Choisissz une classe");
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> ListSalleClasses = Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId);
            if (ListSalleClasses.Count > 0)
                foreach (SalleClasse sc in ListSalleClasses)
                    cbSalleClasse.Items.Add(sc);
            cbSalleClasse.SelectedIndex = 0;
        }
        public void AddControls()
        {
            //Add a header
            EcoleFactory Factory = new EcoleFactory();
            //SalleClasse salleClasse = Factory.getSalleClasseById(_salleClasseId);
            Ecole ecole = Factory.getEcoleById(_ecoleId);
             _header = new Header("Emploi du temps");
            _header.CloseClicked += new EventHandler(CloseControlClicked);
            _header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(_header);

            //Add a footer
            AddDeleteViewUpdateReportPrint footer = new AddDeleteViewUpdateReportPrint(true, true, true, true, true, true);
            footer.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(footer);

            footer.btnDelete.Visible = false;
            footer.btnPrint.Visible = false;
            footer.btnReport.Visible = false;
            footer.btnUpdate.Visible = false;
            footer.btnView.Visible = false;

            footer.AddClicked += new EventHandler(AddRecordClicked);
            footer.DeleteClicked += new EventHandler(DeleteRecordClicked);
            footer.UpdateClicked += new EventHandler(UpdateRecordClicked);
            footer.ViewClicked += new EventHandler(ViewRecordClicked);
            footer.ReportClicked += new EventHandler(GenerateReportClicked);
            footer.PrintClicked += new EventHandler(PrintRecordsClicked);
        }

        public void LoadEmploiDuTemps(long salleClasseId)
        {
            EcoleFactory Factory = new EcoleFactory();
            _header.lblHeader.Text = "Emploi du temps de la classe de " + Factory.getSalleClasseById(salleClasseId).Code;
            pnlBodyEmploiDuTemps.Controls.Clear();
            SalleClasse salleClasse = Factory.getSalleClasseById(salleClasseId);
            if (salleClasse != null)
            {
                WeeklyCoursPrevu ctrl = new WeeklyCoursPrevu(salleClasse.Id, _firstDay);
                ctrl.Dock = DockStyle.Fill;
                pnlBodyEmploiDuTemps.Controls.Add(ctrl);
            }
        }

        private void CloseControlClicked(object sender, EventArgs e)
        {
            //May be add a pop up window asking user if really want to close the control/form
            pnlMain.Controls.Clear();
            //restore the menu panel to show the menu
            Control ctrl = this.Parent.Parent;
            Control ctrlMenuPanel = ctrl.Controls.Find("pnlMenu", true)[0];
            //Control ctrlMenuPanel = ctrlMainPanel.Controls.Find("pnlMenu", true)[0];
            ctrlMenuPanel.Visible = true;
        }
        private void AddRecordClicked(object sender, EventArgs e)
        {
            if (cbSalleClasse.SelectedIndex > 0)
            {
                long salleClasseId = ((SalleClasse)cbSalleClasse.SelectedItem).Id;
                EcoleFactory Factory = new EcoleFactory();
                SalleClasse salleClasse = Factory.getSalleClasseById(salleClasseId);
                CreateCoursPrevu form = new CreateCoursPrevu(salleClasse.Id, _userName);
                form.ShowDialog();
                LoadEmploiDuTemps(salleClasseId);
            }
        }

        private void DeleteRecordClicked(object sender, EventArgs e)
        {

        }

        private void UpdateRecordClicked(object sender, EventArgs e)
        {

        }

        private void ViewRecordClicked(object sender, EventArgs e)
        {

        }

        private void GenerateReportClicked(object sender, EventArgs e)
        {

        }

        private void PrintRecordsClicked(object sender, EventArgs e)
        {

        }

        private void cbSalleClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSalleClasse.SelectedIndex > 0)
            {
                long salleClasseId = ((SalleClasse)cbSalleClasse.SelectedItem).Id;
                LoadEmploiDuTemps(salleClasseId);
            }
        }
    }
}
