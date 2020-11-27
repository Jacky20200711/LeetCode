using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q22_Generate_Parentheses_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q22_Generate_Parentheses_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool HasSameContent(IList<string> answer, IList<string> verify)
        {
            for (int i = 0; i < answer.Count; i++)
            {
                if(answer[i] != verify[i])
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            Program UnitTest = new Program();
            IList<string> answer, verify;

            // --------------------------------------------------------------
            answer = new List<string> 
            {
                "((()))", "(()())", "(())()", "()(())", "()()()"
            };

            verify = UnitTest.GenerateParenthesis(3);

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // --------------------------------------------------------------
            answer = new List<string>
            {
                "()"
            };

            verify = UnitTest.GenerateParenthesis(1);

            Assert.AreEqual(true, HasSameContent(answer, verify));
            // --------------------------------------------------------------

        }
    }
}