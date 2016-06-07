using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logic
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
            if (isWeekend == true)
            {
                cigars = cigars + 1000;
            }

            if (cigars <= 39)
            {
                return false;
            }
            if (cigars >= 40 && cigars <= 60)
            {
                return true;
            }
            if (cigars <= 61)
            {
                return true;
            }
            return false;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer == true)
            {
                temp += 10;
            }
            if (temp >= 60 && temp <= 90)
            {
                return true;
            }
            return false;
        }
    }
}
