using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {




    }

        public static List<int> GetRandomNumbers(int count)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number;

                do
                {
                    number = random.Next(1, 30);
                } while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }
           
            return randomNumbers;
            Console.ReadLine();
        }

    }
}
