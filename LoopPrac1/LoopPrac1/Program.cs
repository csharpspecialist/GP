using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] workers = {"dave", "bill", "Fred", "mark" };
            foreach (var people in workers)
            {
                Console.WriteLine(people);
            }
            Console.ReadLine();
        }
    }
}
