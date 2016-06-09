using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = AddOrSubtract(5, 2, true);
            Console.WriteLine("total of 5 + 2 = {0}", total);

            total = AddOrSubtract(8, 6, false);
            Console.WriteLine("total of 8 + 6 = {0}", total);

            total = AddOrSubtract(9, 10, true);
            Console.WriteLine("total of 9 + 10 = {0}", total);

            total = AddOrSubtract(5, 20, false);
            Console.WriteLine("total of 5 + 20 = {0}", total);

            total = AddOrSubtract(15, 10, true);
            Console.WriteLine("total of 15 + 10 = {0}", total);
            Console.ReadKey();
        }



        static int AddOrSubtract(int a, int b, bool doAdd)
        {
            int sum;
            if (doAdd)
            {
                sum = a + b;
            }
            else if (a > b)
            {
                sum = a - b;
            }
            else
            {
                sum = b - a;
            }
            return sum;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
           bool sleepIn;

            if (isWeekday)
            {
               sleepIn = true;
                return true;
            }
            if (isVacation)
            {
                sleepIn = true;
                return true;
            }
            else
                sleepIn = false;
            return false;

        }

    }
}