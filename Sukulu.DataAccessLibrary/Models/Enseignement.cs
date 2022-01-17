using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Enseignement : BaseClass
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public long SystemeScolaireId { get; set; }
        public virtual SystemeScolaire SystemeScolaire { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
