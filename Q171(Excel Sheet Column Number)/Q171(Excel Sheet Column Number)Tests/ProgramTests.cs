using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Q171_Excel_Sheet_Column_Number_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TitleToNumberTest()
        {
            Program testClass = new Program();

            Assert.AreEqual(1, testClass.TitleToNumber("A"));
            Assert.AreEqual(28, testClass.TitleToNumber("AB"));
            Assert.AreEqual(701, testClass.TitleToNumber("ZY"));
            Assert.AreEqual(2147483647, testClass.TitleToNumber("FXSHRXW"));
        }
    }
}