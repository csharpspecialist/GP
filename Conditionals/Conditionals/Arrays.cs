using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Conditionals
{
   public class Arrays
   {
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                
            }
            return true;
        }

        public string AltPairs(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length - 1; i += 4) ///HELP
            {
                newString = newString + str.Substring(i, 1) + str.Substring((i + 1), 1);
            }
            return newString;
        }





    }
}
