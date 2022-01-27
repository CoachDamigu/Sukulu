using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Evaluation : BaseClass
    {
        public string Code { get; set; }
        public string Name { get; set; }
        [Required]
        public long MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
