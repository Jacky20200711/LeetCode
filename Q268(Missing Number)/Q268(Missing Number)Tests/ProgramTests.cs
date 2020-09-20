using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q268_Missing_Number_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q268_Missing_Number_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MissingNumberTest()
        {
            Program testClass = new Program();

            Assert.AreEqual(0, testClass.MissingNumber(new int[0]));
            Assert.AreEqual(1, testClass.MissingNumber(new int[1] { 0 }));
            Assert.AreEqual(0, testClass.MissingNumber(new int[1] { 1 }));
            Assert.AreEqual(2, testClass.MissingNumber(new int[2] { 0, 1 }));
            Assert.AreEqual(0, testClass.MissingNumber(new int[2] { 1, 2 }));
            Assert.AreEqual(1, testClass.MissingNumber(new int[2] { 0, 2 }));
            Assert.AreEqual(2, testClass.MissingNumber(new int[3] { 3, 0, 1 }));
            Assert.AreEqual(0, testClass.MissingNumber(new int[3] { 1, 2, 3 }));
            Assert.AreEqual(8, testClass.MissingNumber(new int[9] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
        }
    }
}