using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q48_Rotate_Image_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q48_Rotate_Image_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            Program UnitTest = new Program();

            //----------------------------------------
            // 第一筆測資
            int[][] Sample = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5, 6 },
                new int[]{ 7, 8, 9 },
            };

            UnitTest.Rotate(Sample);

            int[][] Answer = new int[][]
            {
                new int[]{ 7, 4, 1 },
                new int[]{ 8, 5, 2 },
                new int[]{ 9, 6, 3 },
            };

            for(int i = 0; i < Sample.Length; i++)
            {
                for (int j = 0; j < Sample.Length; j++)
                {
                    if(Sample[i][j] != Answer[i][j])
                    {
                        Assert.Fail();
                    }
                }
            }
            //----------------------------------------
            // 第二筆測資
            Sample = new int[][]
            {
                new int[]{ 1 }
            };

            UnitTest.Rotate(Sample);

            Answer = new int[][]
            {
                new int[]{ 1 }
            };

            for (int i = 0; i < Sample.Length; i++)
            {
                for (int j = 0; j < Sample.Length; j++)
                {
                    if (Sample[i][j] != Answer[i][j])
                    {
                        Assert.Fail();
                    }
                }
            }
            //----------------------------------------
        }
    }
}