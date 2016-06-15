using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probojit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            SortedDictionary<int,int> track = new SortedDictionary<int, int>();

            for (int i = 0; i < 100; i++)
            {
                int outcome = Add(rand.Next(1, 7), (rand.Next(1,7)));

                if (track.ContainsKey(outcome))
                {
                    track[outcome]++;
                }
                else
                {
                   track.Add(outcome, 1);
                }


            }


            foreach (var result in track)
            {
                Console.WriteLine("Dice Val:{0,3} for the times: {1,3} ", result.Key,result.Value);
            }
            Console.ReadLine();
        }

        public static int (Add)
    }
}
