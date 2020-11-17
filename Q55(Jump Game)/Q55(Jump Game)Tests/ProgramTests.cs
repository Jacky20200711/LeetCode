using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q55_Jump_Game_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q55_Jump_Game_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(true, unitTest.CanJump(new int[] { 0 }));
            Assert.AreEqual(true, unitTest.CanJump(new int[] { 2 }));
            Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0 }));
            Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0, 0 }));
            Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Assert.AreEqual(true, unitTest.CanJump(new int[] { 2, 0, 3, 2, 1, 0 }));

            Assert.AreEqual(false, unitTest.CanJump(new int[] { 0, 3 }));
            Assert.AreEqual(false, unitTest.CanJump(new int[] { 3, 2, 1, 0, 4 }));
            Assert.AreEqual(false, unitTest.CanJump(new int[] { 2, 0, 3, 2, 1, 0, 1 }));
        }
    }
}