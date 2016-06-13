using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPracticeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> fruit = new Dictionary<int, int>();

            fruit.Add(1,100);
            fruit.Add(2, 200);
            fruit.Add(3, 300);
            fruit.Add(4, 400);

            for (int i = 0; i < 10; i++)
            {
                if (fruit.ContainsKey(i))
                {
                    fruit[i]++; 
                }
            }


            foreach (int key in fruit.Keys)
            {
                Console.WriteLine("{0} : {1}",key,fruit[key]);
            }


            Console.ReadKey();


            int[] numbers = {1, 2, 3, 4, 5};

            Console.WriteLine(numbers[4]);
            if (numbers[0] > numbers[numbers.Length - 1])
            {
               
            }
            Console.WriteLine(numbers[4]);

            Console.ReadKey();


        }
}
}
