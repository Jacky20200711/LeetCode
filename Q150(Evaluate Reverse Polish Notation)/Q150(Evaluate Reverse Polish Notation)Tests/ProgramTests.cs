using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q150_Evaluate_Reverse_Polish_Notation_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q150_Evaluate_Reverse_Polish_Notation_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            Program unitTest = new Program();

            Assert.AreEqual(9, unitTest.EvalRPN(new string[] { "2", "1", "+", "3", "*" }));
            Assert.AreEqual(6, unitTest.EvalRPN(new string[] { "4", "13", "5", "/", "+" }));
            Assert.AreEqual(22, unitTest.EvalRPN(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
            Assert.AreEqual(2, unitTest.EvalRPN(new string[] { "2" }));
            Assert.AreEqual(1, unitTest.EvalRPN(new string[] { "3", "2", "-" }));
            Assert.AreEqual(1, unitTest.EvalRPN(new string[] { "3", "2", "/" }));
        }
    }
}