using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q316_Remove_Duplicate_Letters_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q316_Remove_Duplicate_Letters_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void RemoveDuplicateLettersTest()
        {
            Program UnitTest = new Program();
            Assert.AreEqual("abc", UnitTest.RemoveDuplicateLetters("bcabc"));
            Assert.AreEqual("acdb", UnitTest.RemoveDuplicateLetters("cbacdcbc"));
            Assert.AreEqual("a", UnitTest.RemoveDuplicateLetters("a"));
            Assert.AreEqual("abcde", UnitTest.RemoveDuplicateLetters("eabcde"));
        }
    }
}