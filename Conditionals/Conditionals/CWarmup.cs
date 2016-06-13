using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

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

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            hour = 0;
            if (isTalking)

            if(hour <= 7 || hour >= 20)
            {
                return true;
            }

            return false;
        }

        public bool Makes10(int a, int b)
        {
            int sum = 10;

            if (a == 10 || b == 10)
            {
                return true;
            }
            else if(a + b == sum)
            {
                return true;
            }
            return false;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 <= 0 && temp2 >= 100)
            {
                return true;
            }
            return false;
        }

        public bool Between10and20(int a, int b)
        {
            if (a >= 10 && a <= 20)
            {
                return true;
            }
            else if (b >= 10 && b <= 20)
            {
                return true;
            }
            return false;
        }

        public bool HasTeen(int a, int b, int c)
        {
            if(a >= 13 && a <= 19)
            {
                return true;
            }
            else if (b >= 13 && b <= 19)
            {
                return true;
            }
            else if (c >= 13 && c <= 19)
            {
                return true;
            }
            return false;
        }

        public bool SoAlone(int a, int b)
        {
            if(a <= 13 || b <= 13 && a <= 19 || b <= 19)
            {
                return true;
            }
            
            else if (a == 13 && b == 13)
            {
                return false;
            }
            return true;
        }
    }
}
