using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndPartials
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling constructor w Parameter
            Player p1 = new Player("Player 1");

            //calling constructor without parameter 
            Player p2 = new Player();

            //object initializers
            GameWorkFlow game = new GameWorkFlow()
            {
                Player1 = p1,
                Player2 = p2
            }
            ;

            game.PlayGame();
            Console.ReadLine();
        }

      
    }
}
