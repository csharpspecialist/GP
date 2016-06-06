using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernPrac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name you fav sport");
            string sporto = Console.ReadLine();

            string like = (sporto == "Basketball" || sporto == "Football") ? "Great Choice" : "U R A Wimp!!!";
            Console.WriteLine(like);

            Console.WriteLine("Name you fav SUV");
            string biq = Console.ReadLine();

            string ans = "";
            switch(biq)
            {
                case "Rav 4":
                    ans = "Chick Type Suv";
                    break;

                case "Explorer":
                    ans = "Mans Vehicle";
                    break;

                case "Kia Sorrento":
                    ans = "Ya Big Softie!!!!";
                    break;

                case "Edge":
                    ans = "Its An OK Choice";
                    break;

                case "RX370":
                    ans = "Cute Mobile";
                    break;

                default:
                    ans = "U R A Straight Dummy!!!";
                    break;

                   

            }
            Console.WriteLine(ans);

            Console.ReadLine();

            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
                if (i==11)
                {
                    Console.WriteLine("11 tried to hide but her butt was sticking out!!!!");
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
