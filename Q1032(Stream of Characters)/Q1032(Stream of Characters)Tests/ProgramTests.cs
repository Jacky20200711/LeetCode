using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1032_Stream_of_Characters_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q1032_Stream_of_Characters_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SearchWordTest()
        {
            string[] words;
            Program.StreamChecker streamChecker;

            words = new string[] { "cd", "f", "kl", "app" };
            streamChecker = new Program.StreamChecker(words);
            Assert.AreEqual(false, streamChecker.Query('a'));
            Assert.AreEqual(false, streamChecker.Query('b'));
            Assert.AreEqual(false, streamChecker.Query('c'));
            Assert.AreEqual(true, streamChecker.Query('d'));
            Assert.AreEqual(false, streamChecker.Query('e'));
            Assert.AreEqual(true, streamChecker.Query('f'));
            Assert.AreEqual(false, streamChecker.Query('g'));
            Assert.AreEqual(false, streamChecker.Query('h'));
            Assert.AreEqual(false, streamChecker.Query('i'));
            Assert.AreEqual(false, streamChecker.Query('j'));
            Assert.AreEqual(false, streamChecker.Query('k'));
            Assert.AreEqual(true, streamChecker.Query('l'));
            Assert.AreEqual(false, streamChecker.Query('a'));
            Assert.AreEqual(false, streamChecker.Query('p'));
            Assert.AreEqual(true, streamChecker.Query('p'));
            Assert.AreEqual(false, streamChecker.Query('p'));
        }
    }
}