using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DoWhilePractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rgen = new Random();

            int rnum = rgen.Next(1, 21);

            int guessNum = 1;

            Console.WriteLine("Whats your guess between 1 and 21??");
            string choice = Console.ReadLine();

            int userChoice = int.Parse(choice);


            while (userChoice != rnum)
            {
                Console.WriteLine("Not the correct #...Guess Again!!!");
                choice = Console.ReadLine();
                userChoice = int.Parse(choice);
               
                guessNum++;
            }
            Console.WriteLine("You guessed the mystery # which is {0}",rnum);
            Console.WriteLine("You guessed {0} times!!!",guessNum);
            Console.WriteLine("You are a Winna");
            Console.ReadLine();

            //do
            //{
            //    Console.WriteLine("Would you like to play again???");



            //} while (b);



        }
    }
}
