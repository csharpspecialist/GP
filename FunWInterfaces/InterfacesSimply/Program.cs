using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSimply
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepherd bigdog = new GermanShepherd();
            Console.WriteLine(bigdog.GoForAWalk());
            bigdog.Bark();

            bigdog.Name = "Gambit";
            Console.WriteLine(bigdog.Name);

            Console.WriteLine();

            Chihauhua smallDog = new Chihauhua("Taco");
            Console.WriteLine(smallDog.GoForAWalk());
            smallDog.Bark();


          //      smallDog.Name = "gambit"     this wil not work since its set is private!!!
            Console.ReadLine();
        }
    }
}
