using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Serie : BaseClass
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public long EnseignementId { get; set; }
        public virtual Enseignement Enseignement { get; set; }
        public override string ToString()
        {
            return Code + "[ " + Name + " ]";
        }
    }
}
