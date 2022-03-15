using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class PresenceActions : UserControl
    {
        long _ecoleId;
        long _anneeScolaire;
        string _userName;
        public PresenceActions(long ecoleId, long anneeScolaire, string userName)
        {
            _ecoleId = ecoleId;
            _userName = userName;
            _anneeScolaire = anneeScolaire;
            InitializeComponent();
            btnValidate.Enabled = false;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            cbSelectAllEleves.Enabled = false;
            AddControls();
            LoadSalleClasses();
            LoadCodePresences();
        }


        public void AddControls()
        {
            //Add a header
            EcoleFactory Factory = new EcoleFactory();
            Ecole ecole = Factory.getEcoleById(_ecoleId);
            Header header = new Header(ecole.FullName + "Présences");
            header.CloseClicked += new EventHandler(CloseControlClicked);
            header.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(header);
        }


        private void LoadSalleClasses()
        {
            cbSalleClasses.Items.Clear();
            cbSalleClasses.Items.Add("Choisir une classe");
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> ListSalleClasses = Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaire);
            if (ListSalleClasses.Count > 0)
                foreach (SalleClasse sc in ListSalleClasses)
                    cbSalleClasses.Items.Add(sc);
            cbSalleClasses.SelectedIndex = 0;
        }

        private void LoadCodePresences()
        {
            //cbCodePresences.Items.Add("Choisi une pésence");
            Array codePresences = Enum.GetValues(typeof(CodePresence));
            foreach (CodePresence cp in codePresences)
                cbCodePresences.Items.Add(cp);
            cbCodePresences.SelectedIndex = 0;
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

        private void LoadCoursPrevus()
        {
            cbCoursPrevus.Items.Clear();
            cbCoursPrevus.Items.Add("Choisi un cours");

            if (cbSalleClasses.SelectedIndex > 0 && dtpPresenceDate.Value != null)
            {
                EnseignementFactory Factory = new EnseignementFactory();
                DateTime date = dtpPresenceDate.Value;
                long salleClasseId = ((SalleClasse)cbSalleClasses.SelectedItem).Id;
                List<CoursPrevu> ListCoursPrevus = Factory.getListCoursPrevuOfSalleClasseOfDay(date, salleClasseId).OrderBy(cp => cp.Start).ToList();
                if (ListCoursPrevus.Count > 0)
                    foreach (CoursPrevu cp in ListCoursPrevus)
                        cbCoursPrevus.Items.Add(cp);
                cbCoursPrevus.SelectedIndex = 0;
            }
        }

        private void cbSalleClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoursPrevus();
        }

        private void dtpPresenceDate_ValueChanged(object sender, EventArgs e)
        {
            LoadCoursPrevus();
        }

        private void cbCoursPrevus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvPresences.DataSource = null;
            //btnValidate.Enabled = false;
            lbEleves.Items.Clear();
            //dgvPresences.DataSource = null;
            dgvPresences.Rows.Clear();
            btnValidate.Enabled = false;
            if (cbCoursPrevus.SelectedIndex > 0)
            {
                
                CoursPrevu coursPrevu = (CoursPrevu)cbCoursPrevus.SelectedItem;
                EcoleFactory Factory = new EcoleFactory();
                List<Eleve> ListEleves = Factory.getElevesFromSalleClasse(coursPrevu.PortfolioEnseignant.SalleClasseMatiere.SalleClasse.Id);
                if (ListEleves.Count > 0)
                {
                    cbSelectAllEleves.Enabled = true;
                    foreach (Eleve el in ListEleves)
                        lbEleves.Items.Add(el);
                }
                else
                    cbSelectAllEleves.Enabled = false;
            }
        }

        private void cbCodePresences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodePresences.SelectedIndex >= 0 && lbEleves.SelectedItems.Count > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void dgvPresences_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPresences.SelectedRows.Count > 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false; ;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCodePresences.SelectedIndex >= 0 && lbEleves.SelectedItems.Count > 0)
            {
                List<Eleve> ElevesToBeRomoved = new List<Eleve>();
                CodePresence codePresence = (CodePresence)cbCodePresences.SelectedItem;
                foreach (Eleve el in lbEleves.SelectedItems)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    //Add eleve Id
                    DataGridViewCell idCell = new DataGridViewTextBoxCell();
                    idCell.Value = el.Id;
                    row.Cells.Add(idCell);

                    //Add Eleve name
                    DataGridViewCell eleveCell = new DataGridViewTextBoxCell();
                    eleveCell.Value = el.ToString();
                    row.Cells.Add(eleveCell);

                    //Add presence
                    DataGridViewCell presenceCell = new DataGridViewTextBoxCell();
                    presenceCell.Value = codePresence.ToString();
                    row.Cells.Add(presenceCell);

                    ElevesToBeRomoved.Add(el);

                    dgvPresences.Rows.Add(row);
                }

                foreach (Eleve el in ElevesToBeRomoved)
                {
                    lbEleves.Items.Remove(el);
                }

                if (lbEleves.Items.Count == 0)
                {
                    cbSelectAllEleves.Enabled = false;
                    cbSelectAllEleves.Checked = false;
                }
                else
                {
                    cbSelectAllEleves.Enabled = true;
                    cbSelectAllEleves.Checked = false;
                }
            }

            if (dgvPresences.Rows.Count > 0)
                btnValidate.Enabled = true;
            else
                btnValidate.Enabled = false;
        }

        private void lbEleves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEleves.SelectedItems.Count > 0)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            EnseignementFactory Factory = new EnseignementFactory();
            foreach(DataGridViewRow row in dgvPresences.Rows)
            {
                long coursPrevuId = ((CoursPrevu)cbCoursPrevus.SelectedItem).Id;
                long eleveId = (long)row.Cells[0].Value;
                CodePresence codePresence = (CodePresence)row.Cells[2].Value;
                long presenceId = Factory.createPresence(codePresence, null, coursPrevuId, eleveId, _userName, DateTime.Now);
            }
        }

        private void cbSelectAllEleves_CheckedChanged(object sender, EventArgs e)
        {
            if (lbEleves.Items.Count > 0)
            {
                if (cbSelectAllEleves.Checked)
                {
                    lbEleves.BeginUpdate();
                    for (int i = 0; i < lbEleves.Items.Count; i++)
                    {
                        lbEleves.SetSelected(i, true);
                    }
                    lbEleves.EndUpdate();

                    if (cbCodePresences.SelectedIndex >= 0)
                        btnAdd.Enabled = true;
                    else
                        btnAdd.Enabled = false;
                }
                else
                {
                    lbEleves.BeginUpdate();
                    for (int i = 0; i < lbEleves.Items.Count; i++)
                    {
                        lbEleves.SetSelected(i, false);
                    }
                    lbEleves.EndUpdate();
                    btnAdd.Enabled = false;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPresences.SelectedRows.Count > 0)
            {
                EcoleFactory Factory = new EcoleFactory();
                List<DataGridViewRow> rowsToBeRemoved = new List<DataGridViewRow>();
                List<Eleve> elevesToBeAdded = new List<Eleve>();
                foreach (DataGridViewRow row in dgvPresences.SelectedRows)
                {
                    long eleveId = (long)row.Cells[0].Value;
                    Eleve eleve = Factory.getEleveById(eleveId);
                    rowsToBeRemoved.Add(row);
                    elevesToBeAdded.Add(eleve);
                }
                foreach (DataGridViewRow row in rowsToBeRemoved)
                {
                    dgvPresences.Rows.Remove(row);
                }

                foreach (Eleve el in elevesToBeAdded)
                {
                    lbEleves.Items.Add(el);
                }
            }

            if (dgvPresences.SelectedRows.Count > 0)
                btnRemove.Enabled = true;
            else
                btnRemove.Enabled = false;

            if (dgvPresences.Rows.Count > 0)
                btnValidate.Enabled = true;
            else
                btnValidate.Enabled = false;
        }
    }
}
