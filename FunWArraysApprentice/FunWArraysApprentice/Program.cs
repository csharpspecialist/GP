using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWArraysApprentice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.iterateString();
            Program.SplitString();

            Console.ReadLine();


        }

        public void iterateString()
        {
            string s1 = "This is great!!!";

            foreach (char c in s1)
            {
                Console.WriteLine(s1.Length);
                Console.WriteLine(c);
            }
        }

        public static void SplitString()
        {
            string[] words = "This is a sentence".Split();

            foreach (var holla in words)
            {
                Console.WriteLine(holla);
            }
         
            
        }

        public void simpleArray()
        {
            Console.Clear();
            int [] goodInts = new int[3];
            goodInts[0] = 5;
            goodInts[1] = 9;

            Console.WriteLine(goodInts);
            Console.ReadLine();
        }

        public void Reverser()
        {
            string mystring = "Reverse me";

            for (int i = 0; i < mystring.Length; i++)
            {
                Console.WriteLine(mystring[mystring.Length -i -1]);
            }
            Console.ReadLine();

            for (int i = mystring.Length -1; i < 0; i++)
            {
                Console.WriteLine(mystring[mystring.Length - i - 1]);
            }
        }

        public void declareImplicitArrays()
        {
            var a = new[] {1, 10, 100, 1000};
            Console.WriteLine("This is a's array {0} ",a.ToString());
        }

        public void RectMultDimArray()
        {
            Console.Clear();
            int[,] myGrid = new int[5, 6];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <6; j++)
                {
                    myGrid[i, j] = i*j ;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int p = 0; p < 6; p++)
                {
                    Console.WriteLine(myGrid[i,p] + "\t");
                }
            }
        }
    }
}
