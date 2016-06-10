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
        [TestCase(1, 2,3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]



        public void Test_SumDouble(int a,int b, int expected)
        {
           CWarmup sums = new CWarmup();
           int result = sums.SumDouble(a, b);

          
            Assert.AreEqual(expected, result);

        }
    }
}
