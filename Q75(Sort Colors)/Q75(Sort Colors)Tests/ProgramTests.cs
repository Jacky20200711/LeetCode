using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Q75_Sort_Colors_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SortColorsTest()
        {
            Program UnitTest = new Program();

            int[] sample = new int[] { 2, 0, 2, 1, 1, 0 };
            int[] answer = new int[] { 0, 0, 1, 1, 2, 2 };
            UnitTest.SortColors(sample);
            Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));

            sample = new int[] { 2, 0, 1 };
            answer = new int[] { 0, 1, 2 };
            UnitTest.SortColors(sample);
            Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));

            sample = new int[] { 0 };
            answer = new int[] { 0 };
            UnitTest.SortColors(sample);
            Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));

            sample = new int[] { 1 };
            answer = new int[] { 1 };
            UnitTest.SortColors(sample);
            Assert.AreEqual(true, Enumerable.SequenceEqual(sample, answer));
        }
    }
}