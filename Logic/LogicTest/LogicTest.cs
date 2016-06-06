using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Logic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LogicTest
{
    [TestFixture]
    public class LogicTest
    {
       


      [TestCase(60, false , 0)]
        [TestCase(65, false,1 )]
        [TestCase(65, true, 0)]

        public void CaughtSpeeding(int speed, bool isBirthday,int expected)
        {
            Logic.Logic test = new Logic.Logic();
          int result = test.CaughtSpeeding(speed, isBirthday);


            Assert.AreEqual(expected,result);
        }






    }
}
