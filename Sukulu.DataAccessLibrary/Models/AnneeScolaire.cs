using System;
using System.Collections.Generic;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class AnneeScolaire : BaseClass
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return StartDate.Year.ToString() + " - " + EndDate.Year.ToString();
        }
    }
}
