using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Guessing2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            do
            {
                
                Console.WriteLine("Enter Your guess between 1 and 10");
                int userTarget = int.Parse(Console.ReadLine());

                bool gameover;

                int start = 0;

                while (userTarget <= start)
                {
                    Console.WriteLine(start + "");
                    start++;
                }
                
                do
                {
                    Console.WriteLine("Would you like to continue  Y or N");
                    ans = Console.ReadLine().ToUpper();

                    if (ans.ToUpper() == "Q")
                    {
                        return;
                    }

                    if (ans != "Y" && ans != "N")
                    {
                        Console.WriteLine("Invalid choice..Please choose Y or N");
                    }
                    
                } while (ans != "Y" && ans != "N");
            } while (ans == "Y");
        }
    }
}
