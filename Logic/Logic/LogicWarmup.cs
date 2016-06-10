using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicWarmup
    {
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday == true)
            {
                speed = speed - 5;
            }

            if (speed <= 60)
            {
                return 0;
            }

            if (speed >= 61 && speed <= 80)
            {
                return 1;
            }
            if (speed >= 81)
            {
                return 2;
            }
            return -1;
        }

        public bool GreatParty(int cigars, bool isWeekend)
        {
            bool result = false;
            if (isWeekend == true && cigars >= 40)
            {
                result = true;
            }

            //if (cigars <= 39)
            //{
            //    return false;
            //}
            if (cigars >= 40 && cigars <= 60)
            {
                result = true;
            }
            //if (cigars <= 61)
            //{
            //    return true;
            //}
            return result;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            int upperlimit = 90;

            if (isSummer)
            {
                upperlimit = upperlimit + 10;
            }
            if (temp >= 60 && temp <= upperlimit)
            {
                return true;
            }

            return false;
        }

        public bool InRange(int n, bool outsideMode)
        {
            n = 10;
            if (outsideMode)
            {
                if (n >= 1 && n >= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (n >= 1 && n <= 10)
            {
                return true;
            }
            return false;
        }


        public string AlarmClock(int day, bool vacation)
        {
            string buzzer;
            //bool vacation = true;
            if (vacation && (day == 0 || day == 6)) // vacation & weekend
            {
                buzzer = "off";
            }
            else
            if (vacation && (day >= 1 && day <= 5)) // vacation & weekday
            {
                buzzer = "10:00";
            }
            else
            if (day >= 1 && day <= 5) // weekday
            {
                buzzer = "7:00";
            }
            else
            {
                buzzer = "10:00";
            }

            return buzzer;
        }


        public int CanHazTable(int yourStyle, int dateStyle)
        {

            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else if (yourStyle >= 8 || dateStyle >= 8)
            {
                return 2;
            }
            else
                return 1;
        }


    }
}
