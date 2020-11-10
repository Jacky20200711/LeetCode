using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q33_Search_in_Rotated_Sorted_Array_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q33_Search_in_Rotated_Sorted_Array_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            Program unitTest = new Program();
            Assert.AreEqual(0, unitTest.Search(new int[] { 1, 2, 3 }, 1));
            Assert.AreEqual(0, unitTest.Search(new int[] { 1 }, 1));
            Assert.AreEqual(2, unitTest.Search(new int[] { 3, 0, 1 }, 1));
            Assert.AreEqual(2, unitTest.Search(new int[] { 2, 3, 0, 1 }, 0));
            Assert.AreEqual(4, unitTest.Search(new int[] { 4, 5, 6, 7, 0, 1 }, 0));
            Assert.AreEqual(-1, unitTest.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
            Assert.AreEqual(5, unitTest.Search(new int[] { 4, 5, 6, 1, 2, 3 }, 3));
            Assert.AreEqual(6, unitTest.Search(new int[] { 4, 5, 6, 7, 1, 2, 3 }, 3));
            Assert.AreEqual(-1, unitTest.Search(new int[] { 1 }, 0));
            Assert.AreEqual(1, unitTest.Search(new int[] { 8, 9, 2, 3, 4 }, 9));
        }

        [TestMethod()]
        public void GetPivotTest()
        {
            Program unitTest = new Program();
            Assert.AreEqual(3, unitTest.GetPivot(new int[] { 1, 2, 3 }));
            Assert.AreEqual(1, unitTest.GetPivot(new int[] { 1 }));
            Assert.AreEqual(1, unitTest.GetPivot(new int[] { 3, 0, 1 }));
            Assert.AreEqual(2, unitTest.GetPivot(new int[] { 2, 3, 0, 1 }));
            Assert.AreEqual(3, unitTest.GetPivot(new int[] { 4, 5, 6, 1, 2, 3 }));
            Assert.AreEqual(4, unitTest.GetPivot(new int[] { 4, 5, 6, 7, 1, 2, 3 }));
            Assert.AreEqual(2, unitTest.GetPivot(new int[] { 8, 9, 2, 3, 4 }));
        }
    }
}