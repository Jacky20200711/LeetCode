using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q198_House_Robber_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q198_House_Robber_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void RobTest()
        {
            Program testClass = new Program();

            Assert.AreEqual(0, testClass.Rob(new int[0] {  }));
            Assert.AreEqual(1, testClass.Rob(new int[1] { 1 }));
            Assert.AreEqual(4, testClass.Rob(new int[2] { 2, 4 }));
            Assert.AreEqual(4, testClass.Rob(new int[2] { 4, 2 }));
            Assert.AreEqual(4, testClass.Rob(new int[3] { 1, 2, 3 }));
            Assert.AreEqual(5, testClass.Rob(new int[3] { 1, 5, 3 }));
            Assert.AreEqual(4, testClass.Rob(new int[4] { 1, 2, 3, 1 }));
            Assert.AreEqual(4, testClass.Rob(new int[4] { 2, 1, 1, 2 }));
            Assert.AreEqual(3, testClass.Rob(new int[4] { 1, 2, 1, 1 }));
            Assert.AreEqual(12, testClass.Rob(new int[5] { 2, 7, 9, 3, 1 }));
            Assert.AreEqual(18, testClass.Rob(new int[6] { 6, 6, 6, 6, 6, 6}));
        }
    }
}