using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conditionals;
using System.Threading.Tasks;

namespace Conditionals.Test
{
    [TestFixture]
    public class Test_Conditionals
    {
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]



        public void Test_SumDouble(int a, int b, int expected)
        {
            CWarmup sums = new CWarmup();
            int result = sums.SumDouble(a, b);


            Assert.AreEqual(expected, result);

        }

        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]

        public void AreWeInTrouble(bool aSmile, bool bSmile, bool expected)
        {
            CWarmup kids = new CWarmup();
            bool result = kids.AreWeInTrouble(aSmile, bSmile);


            Assert.AreEqual(expected, result);
        }

        [TestCase(23, 4)]
        [TestCase(23, 4)]
        [TestCase(23, 4)]

        public void Diff21(int n, int expected)
        {
            CWarmup diff = new CWarmup();
            int result = diff.Diff21(n);

            Assert.AreEqual(expected, result);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]

        public void ParrotTrouble(bool isTalking, int hour, bool expected)
        {
            CWarmup bird = new CWarmup();
            bool result = bird.ParrotTrouble(isTalking, hour);

            Assert.AreEqual(expected, result);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]

        public void Makes10(int a, int b, bool expected)
        {
            CWarmup digits = new CWarmup();
            bool result = digits.Makes10(a, b);


            Assert.AreEqual(expected, result);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]

        public void IcyHot(int temp1, int temp2, bool expected)
        {
            CWarmup weather = new CWarmup();
            bool result = weather.IcyHot(temp1, temp2);

            Assert.AreEqual(expected, result);
        }


        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]


        public void Between10and20(int a, int b, bool expected)
        {
            CWarmup between = new CWarmup();
            bool result = between.Between10and20(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]


        public void HasTeen(int a, int b, int c, bool expected)
        {
            CWarmup teen = new CWarmup();
            bool result = teen.HasTeen(a, b, c);

            Assert.AreEqual(expected, result);

        }

        [TestCase(13, 19, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]

        public void SoAlone(int a, int b, bool expected)
        {
            CWarmup single = new CWarmup();
            bool result = single.SoAlone(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}
