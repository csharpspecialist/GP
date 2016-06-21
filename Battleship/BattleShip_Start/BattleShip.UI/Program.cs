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
            
            Player p = new Player();
            Player p2 = new Player();
            p.Name = ConsoleIO.PromptString("Player 1 Enter Your Name");
            p2.Name = ConsoleIO.PromptString("Player 2 Enter Your Name");
            ConsoleIO.DisplayBoard(p.Board);

            Console.WriteLine("Are You Ready {0}",p.Name);
            Console.WriteLine("Are You Ready {0}", p2.Name);

            Coordinate p1Coord = new Coordinate(0,0);
            Coordinate p2Coord = new Coordinate(0,0);

            // tried a do here but its not working   do

            //{ 


            Console.WriteLine("Choose your X Coordinate");
            string xAns = (Console.ReadLine().ToUpper());
            //p1Coord.XCoordinate = xCoord;

            int xCoord = 0;
            xAns = "";
            while (xAns != "A" || xAns != "B" || xAns != "C" || xAns != "D"
                || xAns != "E" || xAns != "F" || xAns != "G" || xAns != "H"
                || xAns != "I" || xAns != "J")
            {
             //   xAns = (Console.ReadLine().ToUpper());
               // int.TryParse(xAns, out xCoord);

                xCoord = 0;
                switch (xAns)
                {
                    case "A":
                        xCoord = 1;
                        break;

                    case "B":
                        xCoord = 2;
                        break;

                    case "C":
                        xCoord = 3;
                        break;

                    case "D":
                        xCoord = 4;
                        break;

                    case "E":
                        xCoord = 5;
                        break;

                    case "F":
                        xCoord = 6;
                        break;

                    case "G":
                        xCoord = 7;
                        break;

                    case "H":
                        xCoord = 8;
                        break;

                    case "I":
                        xCoord = 9;
                        break;

                    case "J":
                        xCoord = 10;
                        break;

                    default:
                        Console.WriteLine("Not a valid choice..Chose Again!");
                        break;
                }

                xAns = (Console.ReadLine().ToUpper());
                int.TryParse(xAns, out xCoord);
            }
            Console.WriteLine("We made it to line 87");



            Console.WriteLine("Choose your Y Coordinate");
            string yAns = (Console.ReadLine().ToUpper());
            int yCoord = 0;
            int.TryParse(yAns, out yCoord);
            //p1Coord.YCoordinate = yCoord;

            
            switch (yCoord)
            {
                case 1:
                    yCoord = 1;
                    break;

                case 2:
                    yCoord = 2;
                    break;

                case 3:
                    yCoord = 3;
                    break;

                case 4:
                    yCoord = 4;
                    break;

                case 5:
                    yCoord = 5;
                    break;

                case 6:
                    yCoord = 6;
                    break;

                case 7:
                    yCoord = 7;
                    break;

                case 8:
                    yCoord = 8;
                    break;

                case 9:
                    yCoord = 9;
                    break;

                case 10:
                    yCoord = 10;
                    break;

                default:
                    Console.WriteLine("Not a valid choice..Chose Again!");
                    break;
            }







            var values = Enum.GetValues(typeof(ShipType));

            foreach (ShipType ship in values)
            {

                PlaceShipRequest p1ShipReq = new PlaceShipRequest();
                p1ShipReq.ShipType = ship;
                //p1ShipReq.ShipRequest = Coordinate        
                Console.WriteLine(ship);
            }




            Console.Read();
        }


    }
}
