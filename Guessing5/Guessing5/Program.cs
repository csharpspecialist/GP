


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            
            int theGuess = randNum.Next(1, 21);
            string userChoice = "";
            
            do

            {
                Console.WriteLine("Guess a # between 1 and 20");
                string userTarget = Console.ReadLine();

                int numGuess = 1;

                int start = 0;

                if (userTarget.ToUpper() == "Q")
                {
                    return;
                }

                start = int.Parse(userTarget);

                while (start != theGuess )
                {
                    Console.WriteLine(start + " Is incorrect...Please enter a new guess..1 thru 20");
                    userTarget = Console.ReadLine();
                    start = int.Parse(userTarget);
                    numGuess++;
                }
                Console.WriteLine("You have guessed {0} times " ,numGuess);
                Console.WriteLine("U R A Winna!!!");

                do
                {
                    Console.WriteLine("Would U LIke to continue?? Y or N");
                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "Y" && userChoice != "N")
                    {
                        Console.WriteLine("Invalid choice Please choose either Y or N");
                    }

                } while (userChoice != "Y" && userChoice != "N");
            } while (userChoice == "Y");
        }
    }
}








