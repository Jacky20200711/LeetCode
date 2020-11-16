using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q54_Spiral_Matrix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q54_Spiral_Matrix_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SpiralOrderTest()
        {
            Program UnitTest = new Program();

            // ------------------------------------------------------------------------------------
            int[][] maxtrix = new int[][]{
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            int[] answer = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            Assert.AreEqual(true, Enumerable.SequenceEqual(UnitTest.SpiralOrder(maxtrix), answer));
            // ------------------------------------------------------------------------------------
            maxtrix = new int[][]{
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 },
            };

            answer = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

            Assert.AreEqual(true, Enumerable.SequenceEqual(UnitTest.SpiralOrder(maxtrix), answer));
            // ------------------------------------------------------------------------------------
            maxtrix = new int[][]{
                new int[] { 1 },
            };

            answer = new int[] { 1 };

            Assert.AreEqual(true, Enumerable.SequenceEqual(UnitTest.SpiralOrder(maxtrix), answer));
            // ------------------------------------------------------------------------------------
            maxtrix = new int[][]{
                new int[] { 1, 2 },
            };

            answer = new int[] { 1, 2 };

            Assert.AreEqual(true, Enumerable.SequenceEqual(UnitTest.SpiralOrder(maxtrix), answer));
            // ------------------------------------------------------------------------------------
            maxtrix = new int[][]{
                new int[] { 1 },
                new int[] { 2 },
            };

            answer = new int[] { 1, 2 };

            Assert.AreEqual(true, Enumerable.SequenceEqual(UnitTest.SpiralOrder(maxtrix), answer));
            // ------------------------------------------------------------------------------------
        }
    }
}