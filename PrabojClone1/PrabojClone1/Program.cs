using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrabojClone1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rgen = new Random();

            Console.WriteLine("Rolling the dice...Now");

            int realRan1 = rgen.Next(1, 7);
            int realRan2 = rgen.Next(1, 7);

            int die1 = realRan1;
            int die2 = realRan2;

            int sum = die1 + die2;

            Dictionary<int,int> highRoller = new Dictionary<int, int>();

            for (int i = 0; i < 100; i++)
            {
              
           
                    Console.WriteLine(highRoller[i]);
                    
              
            

            }

            Console.ReadLine();
        }
    }
}
