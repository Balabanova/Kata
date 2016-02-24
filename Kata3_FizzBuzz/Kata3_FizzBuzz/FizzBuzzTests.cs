using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata3_FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestNumber_1()
        {
            var result = 1.FizzBuzz();
            Assert.AreEqual(result,"1");
        }
        [TestMethod]
        public void TestNumber_2()
        {
            var result = 2.FizzBuzz();
            Assert.AreEqual(result, "2");
        }
        [TestMethod]
        public void TestNumber_3()
        {
            var result = 3.FizzBuzz();
            Assert.AreEqual(result, "Fizz");
        }
        [TestMethod]
        public void TestNumber_5()
        {
            var result = 5.FizzBuzz();
            Assert.AreEqual(result, "Buzz");
        }
        [TestMethod]
        public void TestNumber_15()
        {
            var result = 15.FizzBuzz();
            Assert.AreEqual(result, "FizzBuzz");
        }
    }
}
