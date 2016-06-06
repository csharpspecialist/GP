using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name you favorite city");
            string cityname = Console.ReadLine();

            //string blazer = "";

            string dude = (cityname == "Reno" || cityname == "Kansas City")  ? "Reno Rules!!!" : "Why Live There!!";

            Console.WriteLine(dude);

            Console.WriteLine("Name you favorite Singer");
            string singer = Console.ReadLine();

            string crooner = "";

            if (singer == "Rihanna")
            {
                crooner = "She's One of the best In The business";
            }

            else if (singer == "Nikki Minaj")
            {
                crooner = "She's A Crazy One!!!! For Sure!!";
            }

            else if (singer == "Christina Aguilera")
            {
                crooner = "She's a Real Diva";
            }

            else if (singer == "Mary J Blige")
            {
                crooner = "She's a Musical Icon";
            }
            else
            {
                crooner = "Pick a Real Singer Chick!!!";
            }

            Console.WriteLine(crooner);

            Console.ReadLine();


            Console.WriteLine("Name you favorite Girl Group");
            string groupname = Console.ReadLine();

            string blazer = "";

            switch(groupname)
            {
                case "Destiny's Child":
                    blazer = "One Of The Hottest Girl Groups Ever";
                    break;

                case "Spice Girls":
                    blazer = "Biggest Worldwide Girl Group...Period";
                    break;

                case "Pointer Sisters":
                    blazer = "Best of the 80's and 90's";
                    break;

                default:
                    blazer = "Pick some real singers!!!";
                    break;
            }
            Console.WriteLine(blazer);
            Console.ReadLine();   
        }
    }
}
