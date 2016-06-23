using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = new Temperature[]
            {
                new Temperature() {Fahrenheit = 71},
            new Temperature() { Fahrenheit = 120},
            new Temperature() { Fahrenheit = 75},
            new Temperature() { Fahrenheit = 60},



        };
        Array.Sort(temps);

            foreach (var degrees in temps)
            {
                Console.WriteLine("Show {0}, {1}",  degrees.Fahrenheit, degrees.Celcius) ;
            }



        }
    }
}
