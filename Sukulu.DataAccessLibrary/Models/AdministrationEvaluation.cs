using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class AdministrationEvaluation : BaseClass
    {
        [Required]
        public Double PossiblePoints { get; set; }
        [Required]
        public Double PointsEarned { get; set; }
        public string Notes { get; set; }
        [Required]
        public long EleveId { get; set; }
        public virtual Eleve eleve { get; set; }
        [Required]
        public long? EnseignantId { get; set; }
        public virtual Enseignant Enseignant { get; set; }
    }
}
