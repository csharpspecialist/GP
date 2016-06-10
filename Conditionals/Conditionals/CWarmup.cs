using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class CWarmup
    {
        public int SumDouble(int a, int b)
        {
            int sum;
            sum = a + b;
         //   return sum;

            if (a == b)
            {
                sum = sum*2;
            }
            return sum;
            
        }

        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
            {
                return true;
            }
            else if (!aSmile && !bSmile)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        /// <summary>
        /// Given an int n, return the absolute
        ///  value of the difference between n and 21,
        ///  except return double the absolute value of
        ///  the difference if n is over 21. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public int Diff21(int n)
        {
            int result;

            int val21 = 21;

            if (n > val21)
            {
                result = Math.Abs(n - val21)*2;
            }
            else
            {
                result = Math.Abs(n - val21);
            }
            
            return result;
        }
        
    }
}
