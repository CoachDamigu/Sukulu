using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Classe : BaseClass
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public long NiveauId { get; set; }
        public virtual Niveau Niveau { get; set; }
        public long? SerieId { get; set; }
        public virtual Serie Serie { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
