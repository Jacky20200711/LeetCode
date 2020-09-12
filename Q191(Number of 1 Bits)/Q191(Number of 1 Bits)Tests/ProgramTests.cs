using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q191_Number_of_1_Bits_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q191_Number_of_1_Bits_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void HammingWeightTest()
        {
            Program testClass = new Program();

            Assert.AreEqual(0,  testClass.HammingWeight(0));
            Assert.AreEqual(1,  testClass.HammingWeight(1));
            Assert.AreEqual(3,  testClass.HammingWeight(11));
            Assert.AreEqual(1,  testClass.HammingWeight(128));
            Assert.AreEqual(31, testClass.HammingWeight(4294967293));
            Assert.AreEqual(32, testClass.HammingWeight(4294967295));
        }
    }
}