using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class SelectSalleClasse : Form
    {
        public List<SalleClasse> _salleClassesSelected = new List<SalleClasse>();
        long _ecoleId, _anneeScolaireId;
        public SelectSalleClasse(long ecoleId, long anneeScolaireId, Boolean multiselect)
        {
            
            InitializeComponent();
            _ecoleId = ecoleId;
            _anneeScolaireId = anneeScolaireId;
            btnSelect.Enabled = false;
            dgvSalleClasses.MultiSelect = multiselect;
            EcoleFactory Factory = new EcoleFactory();
            Ecole ecole = Factory.getEcoleById(_ecoleId);
            lblHeader.Text = ecole.ShortName;
            LoadSalleClasses();
        }

        private void dgvSalleClasses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalleClasses.SelectedRows.Count > 0) btnSelect.Enabled = true; else btnSelect.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSalleClasses.SelectedRows.Count > 0)
            {
                EcoleFactory Factory = new EcoleFactory();
                foreach (DataGridViewRow row in dgvSalleClasses.SelectedRows)
                {
                    _salleClassesSelected.Add(Factory.getSalleClasseById((long)row.Cells[0].Value));
                }
                this.Close();
            }
        }

        private void LoadSalleClasses()
        {
            dgvSalleClasses.DataSource = null;
            EcoleFactory Factory = new EcoleFactory();
            List<SalleClasse> AllSalleClasses = Factory.getEcoleSalleClasse(_ecoleId, _anneeScolaireId);
            if (AllSalleClasses.Count > 0)
            {
                var source = new BindingSource();
                var salleClasses = from sc in AllSalleClasses
                                   select new
                             {
                                 Id = sc.Id,
                                 Code = sc.Code
                             };
                dgvSalleClasses.AutoGenerateColumns = true;
                source.DataSource = salleClasses;
                dgvSalleClasses.DataSource = source;
                dgvSalleClasses.Columns[0].Visible = false;
            }
        }
    }
}
