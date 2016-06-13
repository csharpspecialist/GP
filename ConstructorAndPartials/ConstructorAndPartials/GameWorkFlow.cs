using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndPartials
{
    public class GameWorkFlow
    {
        //properties
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        /*private static readonly field
        private only inside of the class
        static ...there can be only 1
        readonly - can set in constructor only!!
    */

        private static readonly Random _randomGenerator;

        //static constructor--can only initialize
        //static properties and fields
        //note: it cannot interact with instaces of the class
        static GameWorkFlow()
        {
            _randomGenerator = new Random();
        }

        //private method, only used in this class
        private int Rolldie()
        {
            return _randomGenerator.Next(1, 7);
        }

        public void PlayGame()
        {
            do
            {
                Player1.Score += Rolldie();
                Player2.Score += Rolldie();
            } while (Player1.Score < 100 && Player2.Score < 100);

            Console.ForegroundColor =  ConsoleColor.Cyan;
            Console.WriteLine("Game Over");
            Console.WriteLine($"{Player1.Name}:{Player1.Score} vs {Player2.Name}: {Player2.Score}");

        }
    }
}
