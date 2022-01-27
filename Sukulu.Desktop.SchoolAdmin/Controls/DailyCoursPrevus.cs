using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class DailyCoursPrevus : UserControl
    {
        DateTime _theDay;
        long _salleClasseId;
        string[] Days = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi"};
        public DailyCoursPrevus(DateTime theDay, long salleClasseId)
        {
            _theDay = theDay;
            _salleClasseId = salleClasseId;
            InitializeComponent();
            FillLabel();
            FillCoursPrevuItems();
        }

        private void FillLabel()
        {
            string Day = Days[(int)_theDay.Date.DayOfWeek];
            string Date = _theDay.ToShortDateString();

            lblDay.Text = Day + '\n' + Date;
        }

        private void FillCoursPrevuItems()
        {
            EnseignementFactory Factory = new EnseignementFactory();
            List<CoursPrevu> ListCoursPrevus = Factory.getListCoursPrevuOfSalleClasseOfDay(_theDay, _salleClasseId);
            if (ListCoursPrevus.Count > 0)
            {
                foreach (CoursPrevu cp in ListCoursPrevus)
                {
                    SingleCoursPrevu ctrl = new SingleCoursPrevu(cp.Id);
                    flpCoursPrevuItems.Controls.Add(ctrl);
                }
            }
        }

    }
}
