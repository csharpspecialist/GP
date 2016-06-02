using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilderExample();
            Upper();
            Space();
            Go();
        }




        static void StringBuilderExample()
        {
            Console.WriteLine("=> String Builder Example");

            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.AppendLine("Magic The Gathering");
            sb.AppendLine("Munchkin");
            sb.AppendLine("Settlers");

            Console.WriteLine(sb.ToString());

            sb.Replace("Settlers", "Pandemic");

            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Length);


            sb.Replace("Magic The Gathering", "Doom");
            Console.WriteLine("The List has Changed");
            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
        
        static void Upper()
        {
            Console.WriteLine("favorite gameshow");
            string show = Console.ReadLine();

            Console.WriteLine(show.ToUpper());
            Console.WriteLine(show.ToLower());

            Console.ReadLine();

        }


        static void Space()
        {
            string name1 = "jason";

            Console.WriteLine("Here is a Total BUM!!!! {0}" , name1);
            //Console.ReadLine();
            Console.WriteLine("Whats Your Name??");

            string lacey = Console.ReadLine();

            Console.WriteLine("You Got Straight Worked!!!! {0}", lacey);
            Console.ReadLine();



        }

        static void Go()
        {
            Console.WriteLine("Who Will Win The NBA Finals??");
            string bet = Console.ReadLine();
           // bet.ToUpper();
            Console.WriteLine("WE want the {0} to Win it all", bet.ToUpper() );
            Console.ReadLine();

        }



    }
}
