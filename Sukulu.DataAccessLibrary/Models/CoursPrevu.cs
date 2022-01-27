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
    }
}
