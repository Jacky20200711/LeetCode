using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q200_Number_of_Islands_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q200_Number_of_Islands_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            Program unitTest = new Program();

            // -------------------------------------------------------------
            char[][] sample =
            {
                 new char[] { '1','1','1','1','0' },
                 new char[] { '1','1','0','1','0' },
                 new char[] { '1','1','0','0','0' },
                 new char[] { '0','0','0','0','0' },
            };

            Assert.AreEqual(1, unitTest.NumIslands(sample));
            // -------------------------------------------------------------
            sample = new char[][]
            {
                 new char[] { '1','1','0','0','0' },
                 new char[] { '1','1','0','0','0' },
                 new char[] { '0','0','1','0','0' },
                 new char[] { '0','0','0','1','1' },
            };

            Assert.AreEqual(3, unitTest.NumIslands(sample));
            // -------------------------------------------------------------
            sample = new char[][]
            {
                 new char[] { '1','1','1','1','0' },
                 new char[] { '1','1','0','1','0' },
                 new char[] { '1','1','0','0','1' },
                 new char[] { '0','0','1','0','0' },
            };

            Assert.AreEqual(3, unitTest.NumIslands(sample));
            // -------------------------------------------------------------
        }
    }
}