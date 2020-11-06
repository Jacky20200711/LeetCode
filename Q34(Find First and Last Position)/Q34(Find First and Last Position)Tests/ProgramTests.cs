using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Q34_Find_First_and_Last_Position_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SearchRangeTest()
        {
            Program UnitTest = new Program();

            int[] sample = new int[] { 5, 7, 7, 8, 8, 10 };
            int[] verify = UnitTest.SearchRange(sample, 6);
            int[] answer = new int[] { -1, -1 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));

            sample = new int[] { 5, 7, 7, 8, 8, 10 };
            verify = UnitTest.SearchRange(sample, 8);
            answer = new int[] { 3, 4 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));

            sample = new int[] { };
            verify = UnitTest.SearchRange(sample, 0);
            answer = new int[] { -1, -1 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));

            sample = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            verify = UnitTest.SearchRange(sample, 1);
            answer = new int[] { 0, 9 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));
        }
    }
}