using NUnit.Framework;
using StringCalcKata.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKata.Test
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void Step1_NoParameters()
        {
            Calculator calc = new Calculator();
            int result = calc.Add("");

            Assert.AreEqual(0, result);
        }

        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("17",17)]
        public void Step1_Parameter(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected,result);
        }
        [TestCase("1,2",3)]
        [TestCase("1234,10",1244)]


        public void Step1_TwoParameters(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
