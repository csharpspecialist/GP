using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacky
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Dice1 = new int[7];
            int[] Dice2 = new int[7];

            Random x = new Random();
           // int roll = 0;

            for (var roll = 1; roll <= 100; roll++)
{
                if (x.Next(0, 2) == 0)
                    Dice1[x.Next(1, 7)]++;
                else
                    Dice2[x.Next(1, 7)]++;
            }

            Console.WriteLine("Side  |  times");//How many times sides 1-6 appear.

            for (int side = 1; side < Dice1.Length; side++)
            {
                Console.Write("  " + side + "        ");
                Console.WriteLine(Dice1[side] + Dice2[side]);
            }

            int total = Dice1.Sum() + Dice2.Sum();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("total of 1. Dice: " + Dice1.Sum());
            Console.WriteLine("total of 2. Dice: " + Dice2.Sum());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Total Sum: ");
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
