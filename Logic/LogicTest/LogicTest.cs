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

        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]

        public void GreatParty(int cigars, bool isWeekend, bool expected)
        {
            Logic.Logic party = new Logic.Logic();
            bool result = party.GreatParty(cigars, isWeekend);

            Assert.AreEqual(expected,result);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]

        public void PlayOutside(int temp, bool isSummer, int expected)
        {
            Logic.Logic test = new Logic.Logic();
            bool result =test.PlayOutside(temp, isSummer);
        }

    }
}
