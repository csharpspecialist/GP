using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloW
{
    class Program
    {
        static void Main(string[] args)
        {
            Stringb();
            Console.WriteLine("Hello W");
            //for some reason Stringbuilderexample and StringB never get called???

          string wash =  Console.ReadLine();
            Console.WriteLine(wash.ToUpper());
            Console.WriteLine(wash.ToLower());
            StringWriter();
            StringBuilderExample();
            Words();
        }

        static void Stringb()
        {
            Console.WriteLine("We are here again!!!");
            StringBuilder sb = new StringBuilder("*******************NBA Final Four****************!!!!");


            sb.AppendLine("\n");
            sb.AppendLine("Cleveland Cavaliers!!!");
            sb.AppendLine("Golden State Warriors");
            sb.AppendLine("Toronto Raptors");
            sb.AppendLine("Oklahoma City Thuder");


            /// Console.WriteLine("good Yob!!!");
            //  Console.ReadLine();
        }

        static void StringWriter()
        {
            Console.WriteLine("good Yob!!!");
            Console.ReadLine();
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
        }

        public static void Words()
        {
            int[] dudes = {1, 2, 5, 8, 6, 9, 44};

            foreach (var car in dudes)
            {
                Console.WriteLine(car);
                if (car == 6)
                {
                    Console.WriteLine("We Found # {0}",car );
                    break;
                }
            }
            //{
            //    Console.WriteLine("Lucky #'s are"[i]);
            //}

            Console.ReadLine();

        }
    }
}
