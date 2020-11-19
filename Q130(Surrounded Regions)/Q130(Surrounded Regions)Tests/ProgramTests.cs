using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q130_Surrounded_Regions_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q130_Surrounded_Regions_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool HasSameContent(char[][] region, char[][] answer)
        {
            for (int i = 0; i < region.Length; i++)
            {
                for (int j = 0; j < region[0].Length; j++)
                {
                    if (region[i][j] != answer[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [TestMethod()]
        public void SolveTest()
        {
            Program unitTest = new Program();

            // -------------------------------------------------------------
            char[][] region =
            {
                 new char[] { 'X', 'X', 'X', 'X' },
                 new char[] { 'X', 'O', 'O', 'X' },
                 new char[] { 'X', 'X', 'O', 'X' },
                 new char[] { 'X', 'O', 'X', 'X' },
            };

            char[][] answer =
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'X', 'X' },
            };

            unitTest.Solve(region);

            Assert.AreEqual(true, HasSameContent(region, answer));
            // -------------------------------------------------------------
            region = new char[][]
            {
                 new char[] { 'O', 'X', 'X', 'X' },
                 new char[] { 'X', 'O', 'O', 'X' },
                 new char[] { 'X', 'X', 'O', 'X' },
                 new char[] { 'X', 'X', 'X', 'O' },
            };

            answer = new char[][]
            {
                new char[] { 'O', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'O' },
            };

            unitTest.Solve(region);

            Assert.AreEqual(true, HasSameContent(region, answer));
            // -------------------------------------------------------------
            region = new char[][]
            {
                 new char[] { 'O' },
            };

            answer = new char[][]
            {
                new char[] { 'O' },
            };

            unitTest.Solve(region);

            Assert.AreEqual(true, HasSameContent(region, answer));
            // -------------------------------------------------------------
        }
    }
}