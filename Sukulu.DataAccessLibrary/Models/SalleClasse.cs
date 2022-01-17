using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SalleClasse : BaseClass
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public long AnneeScolaireId { get; set; }
        public virtual AnneeScolaire AnneeScolaire { get; set; }
        [Required]
        public long ClasseId { get; set; }
        public virtual Classe Classe { get; set; }
        [Required]
        public long EcoleId { get; set; }
        public virtual Ecole Ecole { get; set; }
        public override string ToString()
        {
            return Code;
        }
    }
}
