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
        public static bool CheckWinner(string[] pieces)
        {
            if (pieces[0] == pieces[1] && pieces[1] == pieces[2]) return true;
            if (pieces[3] == pieces[4] && pieces[4] == pieces[5]) return true;
            if (pieces[6] == pieces[7] && pieces[7] == pieces[8]) return true;
            if (pieces[0] == pieces[3] && pieces[3] == pieces[6]) return true;
            if (pieces[1] == pieces[4] && pieces[4] == pieces[7]) return true;
            if (pieces[2] == pieces[5] && pieces[5] == pieces[8]) return true;
            if (pieces[0] == pieces[4] && pieces[4] == pieces[8]) return true;
            if (pieces[2] == pieces[4] && pieces[4] == pieces[6]) return true;

            return false;


        }


    }
}
