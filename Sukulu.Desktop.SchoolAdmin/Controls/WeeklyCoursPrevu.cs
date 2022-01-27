using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    public partial class WeeklyCoursPrevu : UserControl
    {
        long _salleClasseId;
        DateTime _firstDay;
        public WeeklyCoursPrevu(long salleClasseId, DateTime firstDay)
        {
            _salleClasseId = salleClasseId;
            _firstDay = firstDay;
            InitializeComponent();
            FillWeeklyLabel();
            FillDailyCoursPrevus();
        }


        private void FillWeeklyLabel()
        {
            lblWeekDisplay.Text = "Du " + _firstDay.Date.ToShortDateString() + " au " + _firstDay.Date.AddDays(6).Date.ToShortDateString();
        }
        private void FillDailyCoursPrevus()
        {
            flpDailyItems.Controls.Clear();
            for (int i=0; i<=6; i++)
            {
                DailyCoursPrevus ctrl = new DailyCoursPrevus(_firstDay.Date.AddDays(i), _salleClasseId);
                //ctrl.Dock = DockStyle.Left;
                flpDailyItems.Controls.Add(ctrl);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _firstDay = _firstDay.AddDays(-7);
            FillWeeklyLabel();
            FillDailyCoursPrevus();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _firstDay = _firstDay.AddDays(7);
            FillWeeklyLabel();
            FillDailyCoursPrevus();
        }
    }
}
