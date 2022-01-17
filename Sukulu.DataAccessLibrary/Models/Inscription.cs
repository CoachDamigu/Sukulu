using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Inscription : BaseClass
    {
        [Required]
        public DateTime DateInscription { get; set; }
        public string Notes { get; set; }
        [Required]
        public long EleveId { get; set; }
        public virtual Eleve Eleve { get; set; }
        [Required]
        public long SalleClasseId { get; set; }
        public virtual SalleClasse SalleClasse { get; set; }
    }
}
