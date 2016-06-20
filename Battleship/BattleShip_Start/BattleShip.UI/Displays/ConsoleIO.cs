using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;

namespace BattleShip.UI.Displays
{
   public class ConsoleIO
    {
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void DisplayBoard(Board board)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i.ToString().PadLeft(5));
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("   ");
            }
        }
        //public static int GetShipRequest(int x, int y)
        //{
        //    Console.WriteLine(x,y).toString;
        //    return Console.ReadLine(x,y);
        //}

        public static int GetXCoordinate(int x)
        {
            Console.WriteLine(x);
            return x;
        }

        public static int GetYCoordinate(int y)
        {
            Console.WriteLine(y);
            return y;
        }
    }
}
