using Sukulu.DataAccessLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class Enseignant: BaseClass
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Sexe { get; set; }
        public string OtherNames { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public byte[] Photo { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
        public string DisplayLF()
        {
            return LastName + " " + FirstName;
        }
        public string DisplayLFNumber()
        {
            return LastName + " " + FirstName + " [" + Number + "]";
        }

        public string DisplayShort()
        {
            return LastName + " " + FirstName[0] + ".";
        }
    }
}
