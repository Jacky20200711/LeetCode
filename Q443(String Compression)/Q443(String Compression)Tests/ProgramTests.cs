using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q443_String_Compression_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q443_String_Compression_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CompressTest()
        {
            Program UnitTest = new Program();
            char[] CharArray;

            CharArray = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            Assert.AreEqual(6, UnitTest.Compress(CharArray));

            CharArray = new char[] { 'a' };
            Assert.AreEqual(1, UnitTest.Compress(CharArray));

            CharArray = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            Assert.AreEqual(4, UnitTest.Compress(CharArray));

            CharArray = new char[] { 'a', 'a', 'a', 'b', 'b', 'a', 'a' };
            Assert.AreEqual(6, UnitTest.Compress(CharArray));
        }
    }
}