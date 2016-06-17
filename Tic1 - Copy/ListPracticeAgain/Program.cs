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

            #region Game Setup
            //TODO: We got player 1, we need player 2
            Console.WriteLine("Player 1...Enter Your Name");
            string player1 = Console.ReadLine();

            Console.WriteLine("Player 2...Enter Your Name");
            string player2 = Console.ReadLine();
            #endregion

            Console.WriteLine("OK {0}, You get to go first",player1.ToUpper());
            Console.WriteLine("{0} , You will go next", player2.ToUpper());
            #region Game Play

            //TODO: Need to loop until game won or no spaces left
            //TODO: Need to alternate which player's turn it is
            int choiceNumber;
            bool gameOver = false;
            int count = 0;


            do
            {

                for (int turn = 0; turn < 2; turn++)
                {
                    do
                    {
                        ShowBoard.DisplayBoard(pieces);
                        Console.WriteLine("Choose between #'s 1 thru 9 ");
                        string choice = Console.ReadLine();

                        choiceNumber = int.Parse(choice);

                    } while (choiceNumber < 1 || choiceNumber > 9);

                    for (int i = 0; i < pieces.Length; i++)
                    {
                        if (pieces[i] == choiceNumber.ToString())
                        {
                            var marker = "X";
                            Console.WriteLine("{0} Turn as Player 1", player1);
                            count++;


                            if (turn == 1)
                            {
                                marker = "O";
                                Console.WriteLine("{0} Turn as Player 2", player2);
                            }

                            pieces[i] = marker;
                            gameOver = ShowBoard.CheckWinner(pieces);

                            break;
                        }
                    }
                    if (gameOver)
                    {
                        Console.WriteLine("The game is OVER!!!");
                        break;
                        
                    }
                    if (count == 9)
                    {
                        Console.WriteLine("The game is a Tie!!!");
                        gameOver = true;
                        break;
                    }
                }
          
            } while (!gameOver);
            #endregion

            Console.WriteLine("Player Won!!");
            Console.ReadLine();

        }

 
    }
}
