using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPracticeAgain
{
    class ShowBoard
    {
        public static void DisplayBoard(string[] pieces)
        {
            Console.WriteLine(" {0}|{1}|{2} ", pieces[0], pieces[1], pieces[2]);
            Console.WriteLine(" {0}|{1}|{2} ", pieces[3], pieces[4], pieces[5]);
            Console.WriteLine(" {0}|{1}|{2} ", pieces[6], pieces[7], pieces[8]);
            
        }



    }
}
