using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woohoo
{
    public class StringWarmup
    {
        public string Abba(string a, string b)
        {
            return string.Format("{a}{b}{b}{a}");
    }
        public string FirstHalf(string str)
        {
            int half = str.Length/2;
            return str.Substring(0, half);
        }

        public string TrimOne(string words)
        {
            return words.Trim();
        }
    }
}
