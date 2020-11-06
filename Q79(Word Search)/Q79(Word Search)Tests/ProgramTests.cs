using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q79_Word_Search_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q79_Word_Search_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ExistTest()
        {
            Program UnitTest = new Program();

            char[][] board = new char[][]
            {
                new char[]{'A', 'B', 'C', 'E'},
                new char[]{'S', 'F', 'C', 'S'},
                new char[]{'A', 'D', 'E', 'E'},
            };

            Assert.AreEqual(true, UnitTest.Exist(board, "ABCCED"));
            Assert.AreEqual(true, UnitTest.Exist(board, "F"));
            Assert.AreEqual(false, UnitTest.Exist(board, "ABCB"));
            Assert.AreEqual(false, UnitTest.Exist(board, "X"));
            Assert.AreEqual(true, UnitTest.Exist(board, "BFSADEESECC"));
        }
    }
}