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
    public partial class SingleCoursPrevu : UserControl
    {

        public SingleCoursPrevu(long coursPrevuId)
        {
            InitializeComponent();
            EnseignementFactory Factory = new EnseignementFactory();
            CoursPrevu coursPrevu = Factory.getCoursPrevuById(coursPrevuId);
            llbMatiere.Text = coursPrevu.PortfolioEnseignant.SalleClasseMatiere.Matiere.Name;
            lblEnseignant.Text = coursPrevu.PortfolioEnseignant.Enseignant.DisplayShort();
            DateTime start = coursPrevu.Start;
            DateTime end = coursPrevu.End;
            string startTime = start.TimeOfDay.Hours.ToString() + ":" + start.TimeOfDay.Minutes.ToString();
            string endTime = end.TimeOfDay.Hours.ToString() + ":" + end.TimeOfDay.Minutes.ToString();
            lblStartEndTime.Text = startTime + " - " + endTime;

        }
    }
}
