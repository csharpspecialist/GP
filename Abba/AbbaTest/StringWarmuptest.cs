using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Woohoo;

namespace AbbaTest
{
    [TestFixture]


    public class StringWarmuptest
    {
        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]

        public void Abba(string a, string b,string expected)
        {
            StringWarmup workStrng = new StringWarmup();
            string result = workStrng.Abba(a,b);

            Assert.AreEqual(expected, result);
        }
        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string str, string expected)
        {
            StringWarmup workStrng = new StringWarmup();
            string result = workStrng.FirstHalf(str);

            Assert.AreEqual(expected,result);
        }

        public void TrimOne(string expected)
        {

        }



    }
}
