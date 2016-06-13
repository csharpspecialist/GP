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
            string userChoice = "";

            do

            {
                Console.WriteLine("Guess a # between a and 20");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {
                    Console.WriteLine(start + "");
                    start++;
                }


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


        

