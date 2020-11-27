using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q15_3Sum_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q15_3Sum_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool HasSameContent(IList<IList<int>> answer, IList<IList<int>> verify)
        {
            if (answer.Count != verify.Count)
            {
                Console.WriteLine($"{answer.Count} {verify.Count}");
                return false;
            }

            // 暴力比對 verify 的陣列是否存在答案
            for (int i = 0; i < verify.Count; i++)
            {
                bool InAnswer = false;

                for (int j = 0; j < answer.Count; j++)
                {
                    if(Enumerable.SequenceEqual(verify[i], answer[j]))
                    {
                        InAnswer = true;
                    }
                }

                if (!InAnswer)
                    return false;
            }
            return true;
        }

        [TestMethod()]
        public void ThreeSumTest()
        {
            Program UnitTest = new Program();
            IList<IList<int>> answer, verify;

            // -------------------------------------------------------------
            answer = new List<IList<int>>
            {
                new int[]{ -1, -1, 2 },
                new int[]{ -1,  0, 1 },
            };

            verify = UnitTest.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
            answer = new List<IList<int>>();

            verify = UnitTest.ThreeSum(new int[] { });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
            answer = new List<IList<int>>();

            verify = UnitTest.ThreeSum(new int[] { 0 });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
            answer = new List<IList<int>>
            {
                new int[]{ 0, 0, 0 },
            };

            verify = UnitTest.ThreeSum(new int[] { 0, 0, 0, 0, 0, 0 });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
            answer = new List<IList<int>>
            {
                new int[]{ -2, 0, 2 },
            };

            verify = UnitTest.ThreeSum(new int[] { -2, 0, 0, 2, 2 });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
            answer = new List<IList<int>>
            {
                new int[]{ -2, 0, 2 },
                new int[]{ -2, 1, 1 },
            };

            verify = UnitTest.ThreeSum(new int[] { -2, 0, 1, 1, 2 });

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // -------------------------------------------------------------
        }
    }
}