using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q152_Maximum_Product_Subarray_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q152_Maximum_Product_Subarray_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MaxProductTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(0, unitTest.MaxProduct(new int[] { -1, 0 }));
            Assert.AreEqual(6, unitTest.MaxProduct(new int[] { 2, 3, -2, 4 }));
            Assert.AreEqual(0, unitTest.MaxProduct(new int[] { -2, 0, -1 }));
            Assert.AreEqual(2, unitTest.MaxProduct(new int[] { 0, -1, -2 }));
            Assert.AreEqual(6, unitTest.MaxProduct(new int[] { 1, 2, 3 }));
            Assert.AreEqual(8, unitTest.MaxProduct(new int[] { 1, 2, 3, 0, 8 }));
            Assert.AreEqual(8, unitTest.MaxProduct(new int[] { -1, -2, -2, -2 }));
        }
    }
}