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

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]

        public void CaughtSpeeding(int speed, bool isBirthday, int expected)
        {
            LogicWarmup test = new LogicWarmup();
            int result = test.CaughtSpeeding(speed, isBirthday);


            Assert.AreEqual(expected, result);
        }

        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]

        public void GreatParty(int cigars, bool isWeekend, bool expected)
        {
            Logic.LogicWarmup party = new Logic.LogicWarmup();
            bool result = party.GreatParty(cigars, isWeekend);

            Assert.AreEqual(expected, result);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]

        public void PlayOutside(int temp, bool isSummer, bool expected)
        {
            LogicWarmup test = new LogicWarmup();
            bool result = test.PlayOutside(temp, isSummer);

            Assert.AreEqual(expected, result);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]

        public void InRange(int n, bool outsideMode, bool expected)
        {
            LogicWarmup score = new LogicWarmup();
            bool result = score.InRange(n, outsideMode);

            Assert.AreEqual(expected, result);
        }

        //[TestCase(1, false, "7:00")]
        //[TestCase(5, false, "7:00")]
        //[TestCase(0, false, "10:00")]


        //public void AlarmClock(int day, bool vacation, bool expected)
        //{
        //    LogicWarmup sleep = new LogicWarmup();
        //    string result = sleep.AlarmClock(day, vacation);

        //    Assert.AreEqual(expected, result);

        //}

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]

        public void CanHazTable(int yourStyle, int dateStyle, int expected)
        {
            LogicWarmup now = new LogicWarmup();
            int result = now.CanHazTable(yourStyle, dateStyle);

            Assert.AreEqual(expected, result);
        }
    }
}
