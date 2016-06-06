using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzy
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("Fizz");
                }
            }
            Console.ReadLine();

        }
    }
}
