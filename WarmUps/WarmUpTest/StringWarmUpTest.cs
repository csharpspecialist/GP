using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WarmUps;

namespace WarmUpTest
{
    [TestFixture]
   
    public class StringWarmUpTest
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]

        public void helloTest(string name, string expected)
        {
            StringWarmUp WorkString = new StringWarmUp();
            string result = WorkString.SayHi(name);

            Assert.AreEqual(expected,result);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word","[[word]]" )]

        public void InsertW(string con, string word,string expected)
        {
            StringWarmUp res = new StringWarmUp();
            string result = res.InsertW(con, word);

            Assert.AreEqual(expected, result);

        }


























        //[TestCase("Bob", "Hello Bob!")]
        //[TestCase("Alice", "Hello Alice!")]
        //[TestCase("X", "Hello X!")]
        //public void SayHiTest(string name, string expected)
        //{
        //    StringWarmUp obj = new StringWarmUp();
        //    string result = obj.SayHi(name);

        //    Assert.AreEqual(expected, result);
        //}




    }
}
