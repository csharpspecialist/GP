using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    public class StringAbba
    {

        public string Abba(string a, string b)
        {
            return string.Format("Hello {a},{b},{b},{a}",a,b);

        }
    }
}
