using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SystemeScolaire : BaseClass
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PrimaryOwner { get; set; }
        public string SecondaryOwner { get; set; }
        public string Description { get; set; }
        [Required]
        public string Country { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
