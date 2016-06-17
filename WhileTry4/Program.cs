using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTry4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();

            int X;

            int resultNum;

            string Result = "";
            int Guesses = 1; ;
            int newRand;

           

            do
            {
                Console.WriteLine("Guess a # Between 1 and 15");
               // Console.WriteLine("Guess Again");
                Result = Console.ReadLine();

                newRand = rand1.Next(1, 15);

                resultNum = int.Parse(Result);



            } while (resultNum != newRand);

            {
                Console.WriteLine("You Guessed The Mystery #!!!");
                Guesses++;
                resultNum = int.Parse(Result);
                Result = Console.ReadLine();
               
                newRand++;

            }
            Console.WriteLine("You guessed {0} times", Guesses);
            //Console.WriteLine(X);
            Console.WriteLine("We made it!!!");
            Console.ReadLine();
        }
    }
}
