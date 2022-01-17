using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class PortfolioEnseignant : BaseClass
    {
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        [Required]
        public long SalleClasseMatiereId { get; set; }
        public virtual SalleClasseMatiere SalleClasseMatiere { get; set; }
        [Required]
        public long EnseignantId { get; set; }
        public virtual Enseignant Enseignant { get; set; }
    }
}
