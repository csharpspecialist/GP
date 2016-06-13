using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name");
            int ans = int.Parse(Console.ReadLine());

            //int realans = int.Parse(ans);






            //bool radar = false;
            //int x = 5;
            //x++;
            while (ans < 10)
            {
                Console.WriteLine("Whatever");
                ans++;

            }
            Console.ReadKey();


            string[] cars = {"Datsun", "Nissan", "Buick", "Chevy"};

            foreach (var print in cars)
            {
                Console.WriteLine(print);
              
            }
            Console.ReadKey();

        }
    }
}
