using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Q41_First_Missing_Positive_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(3, unitTest.FirstMissingPositive(new int[] { 1, 2, 0 }));
            Assert.AreEqual(2, unitTest.FirstMissingPositive(new int[] { 3, 4, -1, 1 }));
            Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 }));
            Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 0 }));
            Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { 3 }));
            Assert.AreEqual(1, unitTest.FirstMissingPositive(new int[] { -1 }));
            Assert.AreEqual(2, unitTest.FirstMissingPositive(new int[] { 1 }));
            Assert.AreEqual(3, unitTest.FirstMissingPositive(new int[] { 0, 2, 2, 1, 1 }));
        }
    }
}