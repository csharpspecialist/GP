using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DateWednesdays
{
    class Program
    {
        static void Main(string[] args)
        {

            Program prog = new Program();


            // prompt for date
            string dateString = prog.displayPrompt("Please enter the day u want to start with");
            DateTime startDate = DateTime.Parse(dateString);

            string numwedstring = prog.displayPrompt("# of Wednesdays u r looking for??");
            int numWed = Int32.Parse(numwedstring);


            //prompt user for # of Wednesdays they want
           // Console.WriteLine("How many Wednesdays to you want");
           // string numWedneday = Console.ReadLine();

           // int numWed = int.Parse(numWedneday);

      

            //loop for numWed to print
            for (int i = 0; i < numWed; i++)
            {
                Console.WriteLine(startDate.ToShortDateString());
                Console.WriteLine(startDate.ToLongDateString());
                Console.WriteLine();

                startDate = startDate.AddDays(7);

                

            }
            Console.ReadLine();

        }

        public string displayPrompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }


        public DateTime GetNextWednesday(DateTime date)
        {
            //loop until we r sure we have 1st wednesday to printout
            while (date.DayOfWeek != DayOfWeek.Wednesday)
            {
               date = date.AddDays(1);
            }
            return date;
        }
    }
}
