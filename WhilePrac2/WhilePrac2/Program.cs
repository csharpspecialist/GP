using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrac2
{
    class Program
    {
        //this one works!!!!!!YESSSS
        //but U can never guess the number!!!!!
        //Randall showed me how to fix it!!!

        static void Main(string[] args)
        {
            Random nRand = new Random();

            string wish = "";
            int numGuess = 1;
            do


            {

                Console.WriteLine("Choose a # Between 1 and 20");
                string ans = Console.ReadLine();

                int hit = nRand.Next(1, 21);

                if (ans.ToUpper() == "Q")
                {
                    break;
                }


                int gNumber = int.Parse(ans);

                while (gNumber != hit)

                {
                    Console.WriteLine("You missed the #...Guess again");
                    ans = Console.ReadLine();
                    gNumber = int.Parse(ans);
                    numGuess++;


                }
                Console.WriteLine("You are correct!!!");
                Console.WriteLine("You have guessed {0} times ", numGuess);
                Console.WriteLine("U R A Winna!!!");



                do
                {
                    Console.WriteLine("Do you want to play again?...Y or N");
                    wish = Console.ReadLine().ToUpper();

                    if (wish != "Y" && wish != "N")
                    {
                        Console.WriteLine("We don't understand your answer..Either Y or N");
                    }


                } while (wish != "Y" && wish != "N");
            } while (wish == "Y");





        }
    }
}
