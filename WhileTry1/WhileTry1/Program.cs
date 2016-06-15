﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WhileTry1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = PromptNumber("Enter a number");
            Console.WriteLine("You have entered an " + n);
        }

        public static int PromptNumber(string message)
        {
            Random nRand = new Random();

            Console.WriteLine("Pick a number between 1 and 20");
            string userChoice = Console.ReadLine();

            int n;
            bool isValid = false;

            do
            {

                Console.WriteLine("This is not a valid choice!!  Try again!!");
                Console.WriteLine("Pick a number between 1 and 20");
                userChoice = Console.ReadLine();
                isValid = int.TryParse(userChoice, out n);

                if (userChoice.ToUpper() == "Q")
                {
                    break;
                }


            } while (!isValid && (n < 1 || n > 10));
            return n;

            //int randNum = nRand.Next(1, 21);

            //if (randNum == n)
            //{
            //    Console.WriteLine("You are  winner!!!");

            //}
            //else if (randNum != n)
            //{
            //    Console.WriteLine("Guess again");
            //}

            //do
            //{
            //    Console.WriteLine("Do you want to play again..Y or N");

            //}while()


    }


    }
}
