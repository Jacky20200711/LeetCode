using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1_Two_Sum_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1_Two_Sum_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            Program UnitTest = new Program();
            int[] sample, verify, answer;

            sample = new int[] { 2, 7, 11, 15 };
            verify = UnitTest.TwoSum(sample, 9);
            answer = new int[] { 0, 1 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));

            sample = new int[] { 2, 3, 2, 3 };
            verify = UnitTest.TwoSum(sample, 6);
            answer = new int[] { 1, 3 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));
        }
    }
}