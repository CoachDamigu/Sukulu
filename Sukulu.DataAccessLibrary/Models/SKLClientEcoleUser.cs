using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLClientEcoleUser : BaseClass
    {
        [Required]
        public long SKLClientEcoleId { get; set; }
        public virtual SKLClientEcole SKLClientEcole { get; set; }
        [Required]
        public long SKLUserId { get; set; }
        public virtual SKLUser SKLUser { get; set; }
    }
}
