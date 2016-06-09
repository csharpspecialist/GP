using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUps
{
    public class StringWarmUp
    {


        public string SayHi(string name)
        {

            return string.Format("Hello {0}!", name);
        }

        //public int Countx(string str)
        //{
        //    int xtimes = 0;

        //    for (int i = 0; i < str.Length - 1; i++)
        //    {
                
        //    }
        //}

        //public bool Nearhunderd(int n)

        //{
        //    int answer1 = Math.Abs(100 - n);
        //    int answer2 = Math.Abs(200 - n);


        //    if (answer1 == )
        //}
        public string InsertW(string con, string word)
        {
            string sep = con.Substring(0, 2);
            string sep2 = con.Substring(con.Length -2,2);

            string newword = string.Format("answer is  ,{sep},{sep2},{word}");

            return con;
        }
    }
}
