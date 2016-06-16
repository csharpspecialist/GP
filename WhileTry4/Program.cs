using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTry4
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            String Result = Console.ReadLine();

            while (!Int32.TryParse(Result, out X))
            {
                Console.WriteLine("Not a valid number, try again.");

                Result = Console.ReadLine();
            }
            Console.WriteLine(X);
            Console.WriteLine("We made it!!!");
            Console.ReadLine();
        }
    }
}
