using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StrConcat();
            VerbatimStrings();
            EscapeCharacters();
            StringBuilderex();
            StringImmutable();
            BasicStringFunctionality();
            StringEQ();
            Crazy();
            Console.ReadLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality");

            string fname = "James";
            Console.WriteLine("Value of Fname is  {0} ", fname);

            Console.WriteLine("The First Name is {0} Characters", fname.Length);
            Console.WriteLine("The First Name is {0} All Uppercase", fname.ToUpper());
            Console.WriteLine("The First Name is {0} All Lowercase", fname.ToLower());
            Console.WriteLine("Does this first name have a j {0}", fname.ToUpper().Contains("j"));
            Console.ReadLine();

            //day 2 add on

            Console.WriteLine("replaced part of the string {0}" , fname.Replace("ames", "immy Johns is Great!!!"));
            Console.ReadLine();
        }

        static void Crazy()
        {
            Console.WriteLine("WE love C #");
            Console.ReadLine();
        }
        static void StrConcat()
        {
            Console.WriteLine("--String Concatenation");
            string s1 = "Hello ";
            string s2 = "World ";
            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);

            Console.ReadLine();
        }

        static void EscapeCharacters()
        {
            Console.WriteLine("--Escape Characters");
            
            Console.WriteLine("Color\tMe\tBadd");

            Console.ReadLine();
        }

        static void VerbatimStrings()
        {
            Console.WriteLine(@"I have a plan to take over the World!!!!");
            
            Console.WriteLine("You Drew First Blood");

            Console.ReadLine();
        }

        static void StringImmutable()
        {
            Console.WriteLine("Immutable Strings!!!!");

            string fn = "Cannonball";

            string upper = fn.ToUpper();

            Console.WriteLine("the first value is {0} and the second {1} ",fn,upper);

            Console.ReadLine();
        }

        static void StringBuilderex()
        {
            Console.WriteLine("StringBuilder EXample!!!!");

            StringBuilder sb = new StringBuilder("************Fantastic Games**********");

            sb.Append("\n");

            sb.AppendLine("Magic The Gathering");

            sb.AppendLine("Gin Rummy");
            sb.AppendLine("UNO");

            sb.AppendLine("Master Chief");

            Console.WriteLine(sb.ToString());

            //Console.ReadLine();


        }


        static void StringEQ()
        {
            Console.WriteLine("StringBuilder EXample!!!!");

            StringBuilder sb = new StringBuilder("************Fantastic Games**********");

            sb.Append("\n");

            sb.AppendLine("Magic The Gathering");

            sb.AppendLine("Gin Rummy");
            sb.AppendLine("UNO");

            sb.AppendLine("Master Chief");

            Console.WriteLine(sb.ToString());

            //Console.ReadLine();


        }





    }
}
