using Sukulu.DataAccessLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLUser : BaseClass
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public string PasswordHashed { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public Boolean FirstTimeLogging { get; set; }
        [Required]
        public Boolean AccountLocked { get; set; }
        [Required]
        public SKLUserType UserType { get; set; }
        public DateTime LastTimeLogging { get; set; }

        public override string ToString()
        {
            return Login + " ( " + LastName + " " + FirstName + " )";
        }
    }
}
