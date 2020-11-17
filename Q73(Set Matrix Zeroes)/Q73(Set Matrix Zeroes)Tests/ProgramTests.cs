using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q73_Set_Matrix_Zeroes_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q73_Set_Matrix_Zeroes_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool HasSameContent(int[][] matrix, int[][] answer)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != answer[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [TestMethod()]
        public void SetZeroesTest()
        {
            Program unitTest = new Program();

            // ---------------------------------------------------
            int[][] matrix =
            {
                new int[]{ 1, 1, 1 },
                new int[]{ 1, 0, 1 },
                new int[]{ 1, 1, 1 },
            };

            int[][] answer =
            {
                new int[]{ 1, 0, 1 },
                new int[]{ 0, 0, 0 },
                new int[]{ 1, 0, 1 },
            };

            unitTest.SetZeroes(matrix);

            Assert.AreEqual(true, HasSameContent(matrix, answer));
            // ---------------------------------------------------
            matrix = new int[][]
            {
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 },
            };

            answer = new int[][]
            {
                new int[]{ 0, 0 ,0, 0 },
                new int[]{ 0, 4, 5, 0 },
                new int[]{ 0, 3, 1, 0 },
            };

            unitTest.SetZeroes(matrix);

            Assert.AreEqual(true, HasSameContent(matrix, answer));
            // ---------------------------------------------------
            matrix = new int[][]
            {
                new int[] { 1 },
                new int[] { 0 },
            };

            answer = new int[][]
            {
                new int[] { 0 },
                new int[] { 0 },
            };

            unitTest.SetZeroes(matrix);

            Assert.AreEqual(true, HasSameContent(matrix, answer));
            // ---------------------------------------------------
        }
    }
}