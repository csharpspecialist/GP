using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TernPrac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name you fav sport");
            string sporto = Console.ReadLine().ToLower();

            string like = (sporto == "basketball" || sporto == "football") ? "Great Choice" : "U R A Wimp!!!";
            Console.WriteLine(like);

            Console.WriteLine("Name you fav SUV");
            string biq = Console.ReadLine().ToLower();

            string ans = "";
            switch(biq)
            {
                case "rav 4":
                case "car":

                    ans = "Chick Type Suv";
                    break;

                case "explorer":
                    ans = "Mans Vehicle";
                    break;

                case "kia Sorrento":
                    ans = "Ya Big Softie!!!!";
                    break;

                case "edge":
                    ans = "Its An OK Choice";
                    break;

                case "rx370":
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

        public string StringSplosion(string str)
        {
            string res = "";

            for (int i = 1; i < str.Length; i++)
            {
                res = res + str.Substring(0, i);
            }
            return str;
            Console.ReadLine();
        }
        
        public string AtFirst(string str)
        {
            int x = str.Length;
            for (int i = 2; i < x; i--)
            {
                string y = "@";
                str += y;
                Console.Write(y);
            }
            return str.Substring(0, 2);
           // Console.ReadLine();
        }

        public string EveryNth(string str, int n)
        {
            string str2 = str.Substring(0, 1);
            string str3 = str;
            for (int i = 1; i < str.Length; i += n)
            {
                str2 += str3.Substring(n, 1);
                str3 = str3.Substring(n);
                Console.Write(n);
            }
            return str2;
            
           // Console.ReadLine();
        }

        
    }
}
