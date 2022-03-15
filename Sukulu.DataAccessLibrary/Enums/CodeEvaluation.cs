using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Enums
{
    public enum CodeEvaluation
    {
        [Display(Name = "Devoir surveillé")]
        DevoirSurveille,
        [Display(Name = "Interrogation")]
        Interrogation,
        [Display(Name = "Examen régional")]
        ExamenRegional,
        [Display(Name = "Examen national")]
        ExamenNational,
    }
}
