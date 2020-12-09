using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q51_N_Queens_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool HasSameContent(IList<IList<string>> answer, IList<IList<string>> verify)
        {
            for (int i = 0; i < answer.Count; i++)
            {
                for (int j = 0; j < answer[0].Count; j++)
                {
                    if (answer[i][j] != verify[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [TestMethod()]
        public void SolveNQueensTest()
        {
            Program UnitTest = new Program();
            IList<IList<string>> answer;

            /* N = 4 */
            answer = new List<IList<string>>
            {
                 new List<string>{ ".Q..", "...Q", "Q...", "..Q." },
                 new List<string>{ "..Q.", "Q...", "...Q", ".Q.." },
            };

            Assert.AreEqual(true, HasSameContent(answer, UnitTest.SolveNQueens(4)));

            /* N = 1 */
            answer = new List<IList<string>>
            {
                 new List<string>{ "Q" },
            };

            Assert.AreEqual(true, HasSameContent(answer, UnitTest.SolveNQueens(1)));
        }
    }
}