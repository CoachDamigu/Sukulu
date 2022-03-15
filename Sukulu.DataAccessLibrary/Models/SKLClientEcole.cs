using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLClientEcole : BaseClass
    {
        [Required]
        public long SKLClientId { get; set; }
        public virtual SKLClient SKLClient { get; set; }
        [Required]
        public long EcoleId { get; set; }
        public virtual Ecole Ecole { get; set; }
        [DefaultValue("true")]
        public Boolean Enabled { get; set; }
    }
}
