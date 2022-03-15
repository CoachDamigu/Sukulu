using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sukulu.DataAccessLibrary.Enums
{
    public enum SKLUserType
    {
        Eleve,
        Enseignant,
        Parent,
        [Display(Name = "Administrateur d'école")]
        AdminEcole,
        [Display(Name = "Administrateur de l'application SKL")]
        AdminSKL,
        [Display(Name = "Administrateur client")]
        AdminClient
    }
}
