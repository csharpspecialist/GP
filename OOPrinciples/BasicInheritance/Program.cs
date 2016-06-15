using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //defaut constructor for minivan

            Minivan myVan = new Minivan();
            Console.WriteLine($"max speed is {myVan.MaxSpeed}");

            Minivan myVan2 = new Minivan(75, 0);
            Console.WriteLine($"max speed is {myVan2.MaxSpeed}");

            Minivan myVan3 = new Minivan(90);
            Console.WriteLine($"max speed is {myVan.MaxSpeed}");

            Console.ReadLine();
        }
    }
}
