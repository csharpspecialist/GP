using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTry3
{
    class Program
    {
        static void Main(string[] args)
        {
            //YESSS YEESSS YESSS I got assistance for SWGuild Corbin for While statement!!!
            Random rand = new Random();

            Console.WriteLine("Guess a number between 1 and 10");
            string stringGuess = Console.ReadLine();

            int intGuess;
            int.TryParse(stringGuess, out intGuess);

            int randNum = rand.Next(1, 10);

            int guessCount = 1;
            
   
            while (intGuess <1 || intGuess >10 )
            {           
            
                Console.WriteLine("You must choose either a valid # between 1 and 10..Try again!!");
                stringGuess = Console.ReadLine();
                int.TryParse(stringGuess, out intGuess);
                guessCount++;
            }



            while(intGuess != randNum)
            {
                Console.WriteLine("Thats not the correct #...Guess again");
                stringGuess = Console.ReadLine();
                int.TryParse(stringGuess, out intGuess);
                guessCount++;
            }

            Console.WriteLine("Congratulatons...you won!!!");
            Console.WriteLine("Your guessed {0} times",guessCount);

            Console.WriteLine("Would you like to play again?? Y or N");
            stringGuess = Console.ReadLine().ToUpper();

            while(stringGuess != "Y" && stringGuess != "N")
            {
                Console.WriteLine("That is not a Y or N...Would you like to play again??");
                stringGuess = Console.ReadLine();
                int.TryParse(stringGuess, out intGuess);
                //guessCount++;
            }


        }
    }
}
