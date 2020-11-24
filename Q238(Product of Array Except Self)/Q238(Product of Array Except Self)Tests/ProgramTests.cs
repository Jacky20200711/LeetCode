using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Q238_Product_of_Array_Except_Self_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ProductExceptSelfTest()
        {
            Program unitTest = new Program();

            int[] sample = new int[] { 1, 2, 3, 4 };
            int[] verify = unitTest.ProductExceptSelf(sample);
            int[] answer = new int[] { 24, 12, 8, 6 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));

            sample = new int[] { 1, 2, 3, 0 };
            verify = unitTest.ProductExceptSelf(sample);
            answer = new int[] { 0, 0, 0, 6 };
            Assert.AreEqual(true, Enumerable.SequenceEqual(verify, answer));
        }
    }
}