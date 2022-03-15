using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLClient : BaseClass
    {
        [Required]
        public string Name { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
