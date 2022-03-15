using Sukulu.DataAccessLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLUserResource : BaseClass
    {
        [Required]
        public long SKLUserId { get; set; }
        public virtual SKLUser SKLUser { get; set; }
        [Required]
        public SKLResourceType ResourceType { get; set; }
        [Required]
        public long ResourceId { get; set; }
        [Required]
        public Boolean ResourceLocked { get; set; }

    }
}
