using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListPracticeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pieces = { "1", "2", "3", "4", "5", "6", "7","8", "9"};

            Console.WriteLine("What is your name...Player 1");
           // string playerLetter = Console.ReadLine();
            string player1 = Console.ReadLine();

            Console.WriteLine("Let's get started {0} ",player1.ToUpper());

            ShowBoard.DisplayBoard(pieces);
            Console.WriteLine("Choose between #'s 1 thru 9 ");
            string choice = Console.ReadLine();

            int choiceNumber = int.Parse(choice);

            if (choiceNumber >= 1 && choiceNumber <= 9)
            {
                Console.WriteLine("Lets get the game going!!!");
            }
            else
            {
                Console.WriteLine("Please choose a # between 1 and 9..ya dummy");
            }

            for (int i = 0; i < pieces.Length; i++)
            {
                //Console.WriteLine(pieces[i]);
                if (pieces[i] == choice)
                {
                    pieces[i] = "X";
                    break;
                }
            }
            ShowBoard.DisplayBoard(pieces);

           // Console.ReadLine();
        }
    }
}
