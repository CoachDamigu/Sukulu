using Sukulu.DataAccessLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class CoursPrevu : BaseClass
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [Required]
        public long PortfolioEnseignantId { get; set; }
        public virtual PortfolioEnseignant PortfolioEnseignant { get; set; }
        [Required]
        public StatusCoursPrevu StatusCoursPrevu { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            DateTime start = Start;
            DateTime end = End;
            string startTime = start.TimeOfDay.Hours.ToString() + ":" + start.TimeOfDay.Minutes.ToString();
            string endTime = end.TimeOfDay.Hours.ToString() + ":" + end.TimeOfDay.Minutes.ToString();
            return startTime + " - " + endTime + " (" + PortfolioEnseignant.SalleClasseMatiere.Matiere.Name + ")";
        }
    }
}
