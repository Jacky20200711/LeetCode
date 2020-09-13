using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q172_Factorial_Trailing_Zeroes_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q172_Factorial_Trailing_Zeroes_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TrailingZeroesTest()
        {
            Program testClass = new Program();

            Assert.AreEqual(0, testClass.TrailingZeroes(3));
            Assert.AreEqual(1, testClass.TrailingZeroes(5));
            Assert.AreEqual(1, testClass.TrailingZeroes(6));
            Assert.AreEqual(2, testClass.TrailingZeroes(10));
            Assert.AreEqual(6, testClass.TrailingZeroes(25));
            Assert.AreEqual(156, testClass.TrailingZeroes(625));
            Assert.AreEqual(536870902, testClass.TrailingZeroes(2147483647));
        }
    }
}