using System;
using System.Collections.Generic;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLConfig : BaseClass
    {
        public string Code { get; set; }
        public int NumericValue { get; set; }
        public string stringValue { get; set; }
        public Boolean BooleanValue { get; set; }
    }
}
