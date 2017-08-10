using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL;
using BattleShip.UI.Displays;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      BattleShip Rules!!!!\n  You Just Don't Know It Yet");


            //gets both player names and shows board
            Player p = new Player();
            Player p2 = new Player();
            p.Name = ConsoleIO.PromptString("Player 1 Enter Your Name");
            p2.Name = ConsoleIO.PromptString("Player 2 Enter Your Name");
            //public int playerTurn = 0;

            // shows board
            ConsoleIO.DisplayBoard(p.Board);
            
            Console.WriteLine("Are You Ready {0}", p.Name);
            Console.WriteLine("Are You Ready {0}", p2.Name);



            //Coordinate p1Coord = new Coordinate(0, 0);
            //Coordinate p2Coord = new Coordinate(0, 0);

            //marries the enum to the var values
            var values = Enum.GetValues(typeof(ShipType));



            foreach (ShipType ship in values)
            {
                Program scar = new Program();

                int xCoord = scar.GetXCoordinate();

                int yCoord = GetYCoordinate();
                PlaceShipRequest p1ShipReq = new PlaceShipRequest();
                p1ShipReq.ShipType = ship;
                p1ShipReq.Coordinate = new Coordinate(xCoord,yCoord);    ///////
                p1ShipReq.Direction = GetDirection(); 
                     //Placing shiping ship on player 1 board
                     //Checking placeshipresponse
                Console.WriteLine("You have placed a {0}",ship);
            }
            
            Console.Read();
        }

        /// <summary>
        /// Used switch, get user input 1-4
        /// </summary>
        /// <returns></returns>
        private static ShipDirection GetDirection()
        {
            var waves = Enum.GetValues(typeof(ShipDirection));

            foreach (ShipDirection boat in waves)
            {
                //int shipGo = 
            }
            
            //int pointer = 0;
            //while (true)
            //{
                
            //}
            
            return ShipDirection.Down;
        }


        private static int GetYCoordinate()
        {

            int yCoord = 0;
            while (yCoord <1 || yCoord > 10)
            {
                Console.WriteLine("Choose your Y Coordinate Between 1 & 10");
                string yAns = (Console.ReadLine().ToUpper());
                bool isValid  = int.TryParse(yAns, out yCoord);
                if (isValid == false || (yCoord < 1 || yCoord > 10))
                {
                    Console.WriteLine("Not a valid Y Coordinate..Chose Again!");
                }

            }
            return yCoord;
            
        }
        /// <summary>
        /// this is a song that never ends, it goes on and on my friends...
        /// </summary>
        /// <returns></returns>
        private int GetXCoordinate()
        {
            //p1Coord.XCoordinate = xCoord;
            Char letter = '\0';
            do
            {
                Console.WriteLine("Choose a valid X Coordinate between A & J");
                var input = Console.ReadLine();
                if (input != null) letter = input.ToUpper()[0];
                if (letter >= 'A' && letter <= 'J')
                {
                    Console.WriteLine("That choice {0} works!", letter);
                }
                else
                {
                    Console.WriteLine("Please enter a valid Choice");
                }
            } while (letter < 'A' || letter > 'J');
            return letter - 64;
            
      
        }

        //public void TakeTurns()
        //{

        //    do
        //    {
        //        //display current shot hist/board state
        //        //playerturn below
        //        int boardToShootAt = (playerTurn ? 1 : 0);
        //        //cusom array that jerry made named boards below
        //        DisplayShotHistAndBoard(boards[boardToShootAt]);
        //        //prompt player to shoot
        //        //fire shot
        //        //handle shot response

        //    } while (!= gameOver && != gameWon);


        //}

        private void DisplayShotHistAndBoard(object p)
        {
           
        }
    }
}
