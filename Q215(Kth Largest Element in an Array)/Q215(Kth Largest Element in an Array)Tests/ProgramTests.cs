using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q215_Kth_Largest_Element_in_an_Array_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q215_Kth_Largest_Element_in_an_Array_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FindKthLargestTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(5, unitTest.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
            Assert.AreEqual(4, unitTest.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
            Assert.AreEqual(1, unitTest.FindKthLargest(new int[] { 1 }, 1));
            Assert.AreEqual(-1, unitTest.FindKthLargest(new int[] { -1, -1 }, 2));
        }
    }
}