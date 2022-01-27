using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{
    public class DateTimeFactory
    {
        SKLContext _context = new SKLContext();

        public DateTime GetWeekFirstDateFromADate(DateTime ADate)
        {
            int WeekDayNumber = (int)ADate.Date.DayOfWeek;
            if (WeekDayNumber == 1)
                return ADate;
            else
                return ADate.Date.AddDays(-(WeekDayNumber - 1));
        }

        public DateTime GetWeekLastDateFromADate(DateTime ADate)
        {
            int WeekDayNumber = (int)ADate.Date.DayOfWeek;
            if (WeekDayNumber == 0)
                return ADate;
            else
                return ADate.Date.AddDays(7 - WeekDayNumber);
        }

        /// <summary>
        /// Retourne la premiere date egale ou superieure a une date donnée et un jour spécifique
        /// </summary>
        /// <param name="TheDay">Le jour</param>
        /// <param name="TheJour">La Date</param>
        /// <returns></returns>
        public DateTime getFirstDateFromDateAndJour(DateTime TheDay, Jour TheJour)
        {
            if ((int)TheDay.Date.DayOfWeek == (int)TheJour)
            {
                return TheDay;
            }
            else
            {
                if ((int)TheJour > (int)TheDay.Date.DayOfWeek)
                {
                    int DiffDays = (int)TheJour - (int)TheDay.Date.DayOfWeek;
                    return TheDay.AddDays(DiffDays);
                }
                else
                {
                    

                    int DiffDays = (int)TheDay.Date.DayOfWeek - (int)TheJour;
                    return TheDay.AddDays(7 - DiffDays);
                }
            }
        }
    }
}
