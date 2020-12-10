using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q52_N_Queens_II_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q52_N_Queens_II_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TotalNQueensTest()
        {
            Program UnitTest = new Program();

            Assert.AreEqual(1, UnitTest.TotalNQueens(1));
            Assert.AreEqual(0, UnitTest.TotalNQueens(2));
            Assert.AreEqual(0, UnitTest.TotalNQueens(3));
            Assert.AreEqual(2, UnitTest.TotalNQueens(4));
            Assert.AreEqual(10, UnitTest.TotalNQueens(5));
            Assert.AreEqual(4, UnitTest.TotalNQueens(6));
            Assert.AreEqual(40, UnitTest.TotalNQueens(7));
            Assert.AreEqual(92, UnitTest.TotalNQueens(8));
            Assert.AreEqual(352, UnitTest.TotalNQueens(9));
        }
    }
}