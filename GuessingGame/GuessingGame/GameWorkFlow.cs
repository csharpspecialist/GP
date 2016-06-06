using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class GameWorkFlow
    {
        private Random _randGenerator = new Random();

        public void playGame(string playerName)
        {
            int numberToGuess = _randGenerator.Next(1, 21);

            bool guessedCorrectly = false;
            int guesses = 0;

            do
            {
                
           

            Console.WriteLine($"{playerName} Please enter a # between 1 & 20");
            string guess = Console.ReadLine();

                if (guess.ToUpper() == "Q")
                {
                    return;
                }

            int guessInt = int.Parse(guess);

            if (guessInt == numberToGuess)
            {
                if (guesses == 1)
                {
                    Console.WriteLine($"{playerName}You are good at this..U Won on first Try!! ");
                }
                else
                {
                    Console.WriteLine("You guessed the #");
                }

                Console.WriteLine("You guessed the correct #!!");
            }else if (guessInt<= 20 && guessInt >=1)
            {
                Console.WriteLine("Give it a nother shot");
            }
            else
            {
                Console.WriteLine("try a # between 1 and 20 this time");
            }
            } while (!guessedCorrectly);

        }
    }
}
