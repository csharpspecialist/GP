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
    }
}
