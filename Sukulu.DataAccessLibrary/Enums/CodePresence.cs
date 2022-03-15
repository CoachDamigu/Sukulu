using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Enums
{
    public enum CodePresence
    {
        Present,
        Absent,
        [Display(Name = "Absence excusé")]
        AbsenceExcuse,
        [Display(Name = "Absence inexcusé")]
        AbsenceInExcuse,
    }
}
