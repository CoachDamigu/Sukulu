using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SalleClasseMatiere : BaseClass
    {
        [Required]
        public Double Coefficient { get; set; }
        public string Notes { get; set; }
        [Required]
        public long SalleClasseId { get; set; }
        public virtual SalleClasse SalleClasse { get; set; }
        [Required]
        public long MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
