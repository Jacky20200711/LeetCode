using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q128_Longest_Consecutive_Sequence_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q128_Longest_Consecutive_Sequence_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));
            Assert.AreEqual(9, unitTest.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));
            Assert.AreEqual(0, unitTest.LongestConsecutive(new int[] { }));
            Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 1 }));
            Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 3, 6 }));
            Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 5, 7, 9, 10, 4, 8 }));
            Assert.AreEqual(3, unitTest.LongestConsecutive(new int[] { 1, 2, 0, 1 }));
            Assert.AreEqual(1, unitTest.LongestConsecutive(new int[] { 1, 1, 1 }));
            Assert.AreEqual(4, unitTest.LongestConsecutive(new int[] { 5, 7, 9, 10, 4, 8, 8, 7, 7, 9, 10 }));
        }
    }
}