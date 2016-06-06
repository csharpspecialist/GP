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
            for (int tot = 0; tot < 100; tot++)
               // Console.WriteLine([tot]);
            if (tot % 3 ==0)
            {
                Console.WriteLine("Fizz");
            }
            else if (tot % 5 == 0)
                    {
                    Console.WriteLine("Buzz");
                }
                else if (tot % 5 == 0 && tot % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else
                {
                    Console.WriteLine(tot);
                }
            Console.ReadLine();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    
     }
}
