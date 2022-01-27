using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Presence : BaseClass
    {
        [Required]
        public long CoursPrevuId { get; set; }
        public virtual CoursPrevu CoursPrevu { get; set; }
        [Required]
        public long EleveId { get; set; }
        public virtual Eleve Eleve { get; set; }
        [Required]
        public CodePresence Code { get; set; }
        public string Notes { get; set; }
    }
}
