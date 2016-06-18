using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL;
using BattleShip.UI.Displays;

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

            Console.Read();
        }
    }
}
