using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE GUESSING GAME!!");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();

            bool keepPlaying = true;


            do
            {
                GameWorkFlow game = new GameWorkFlow();
                game.playGame(name);

                Console.WriteLine("Would You like to play again");
                string response = Console.ReadLine();

                keepPlaying = TranslateResponsce(response);

            } while (keepPlaying);

            Console.WriteLine("Thanks for playing");
            Console.WriteLine("hit enter to exit!");
            Console.ReadLine();
        }

        static bool TranslateResponsce(string response)
        {
            switch (response.ToUpper())
            {
                case "Y":
                case "Yes":
                case "SURE":
                    return true;
                default:
                    return false;


            }
            
        }
    }
}
