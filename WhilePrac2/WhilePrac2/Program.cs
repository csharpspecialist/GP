﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrac2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Random nRand = new Random();

            string wish = "";
            do
            {

                

                Console.WriteLine("Choose a # Between 1 and 20");
            string ans = Console.ReadLine();

            int numGuess = 1;

            int hit = nRand.Next(1, 21); 

            if (ans.ToUpper() == "Q")
            {
                return;
            }

            int gNumber = int.Parse(ans);

            while (gNumber != hit)

            {
                Console.WriteLine("You missed the #...Guess again");
                ans = Console.ReadLine();
                gNumber = int.Parse(ans);
                hit++;
               

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