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

            Console.WriteLine("Choose your X Coordinate");
            int intXTemp = Convert.ToInt32(Console.ReadLine());
            p1Coord.XCoordinate = intXTemp;

            Console.WriteLine("Choose your Y Coordinate");
            int intYTemp = Convert.ToInt32(Console.ReadLine());
            p1Coord.XCoordinate = intYTemp;
            

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
