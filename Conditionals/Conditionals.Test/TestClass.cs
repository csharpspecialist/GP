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

        public void Makes10(int a, int b, int expected)
        {
            CWarmup digits = new CWarmup();
            bool result = digits.Makes10(a, b);


            Assert.AreEqual(expected, result);
        }
    }
 }
