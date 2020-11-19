using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q162_Find_Peak_Element_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q162_Find_Peak_Element_.Tests
{
    
    [TestClass()]
    public class ProgramTests
    {
        public bool InAnswer(int index, HashSet<int> answer)
        {
            return answer.Contains(index);
        }

        [TestMethod()]
        public void FindPeakElementTest()
        {
            Program unitTest = new Program();
            int index;

            index = unitTest.FindPeakElement(new int[] { 1, 2, 3, 1 });
            Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 2 }));

            index = unitTest.FindPeakElement(new int[] { 1, 2, 1, 3, 5, 6, 4 });
            Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 1, 5 }));

            index = unitTest.FindPeakElement(new int[] { 1 });
            Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 0 }));

            index = unitTest.FindPeakElement(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 3 }));

            index = unitTest.FindPeakElement(new int[] { 1, 2 });
            Assert.AreEqual(true, InAnswer(index, new HashSet<int> { 1 }));
        }
    }
}