using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedingTicket
{
    class Program
    {
        static void Main(string[] args)
        {




     }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
          

            Console.WriteLine("Do You know how fast you were going??");
            if (speed <= 60)
            {
                Console.Write("U were not speeding...go faster so I can give u a ticket!!!");
                return 0;
            }

            else if (speed <= 61 && speed >= 80)
            {
                Console.WriteLine("You are gettin a small ticket today!!!");
                return 1;
            }
            else if (speed >= 81)
            {
                Console.WriteLine("You Butt is going to jail!!!");
            }
               Console.WriteLine("Is It your Birthday??");
           
            return speed;
            Console.ReadLine();
        }
    }


}

