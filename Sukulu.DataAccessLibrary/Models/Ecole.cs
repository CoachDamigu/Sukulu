using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Ecole: BaseClass
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string MainPhone { get; set; }
        public string MainFax { get; set; }
        public string MainEmail { get; set; }
        public string Notes { get; set; }
        [Required]
        public long SystemeScolaireId { get; set; }
        public virtual SystemeScolaire SystemeScolaire { get; set; }
    }
}
