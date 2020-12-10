using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1023_Camelcase_Matching_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1023_Camelcase_Matching_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CamelMatchTest()
        {
            Program UnitTest = new Program();
            string[] Queries;
            string Pattern;
            IList<bool> Answer, Verify;

            Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };
            Pattern = "FB";
            Answer = new List<bool>{ true, false, true, true, false };
            Verify = UnitTest.CamelMatch(Queries, Pattern);
            Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));

            Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };
            Pattern = "FoBa";
            Answer = new List<bool> { true, false, true, false, false };
            Verify = UnitTest.CamelMatch(Queries, Pattern);
            Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));

            Queries = new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" };
            Pattern = "FoBaT";
            Answer = new List<bool> { false, true, false, false, false };
            Verify = UnitTest.CamelMatch(Queries, Pattern);
            Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));

            Queries = new string[] { "CompetitiveProgramming", "CounterPick", "ControlPanel" };
            Pattern = "CooP";
            Answer = new List<bool> { false, false, true };
            Verify = UnitTest.CamelMatch(Queries, Pattern);
            Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));

            Queries = new string[] { "FB" };
            Pattern = "FB";
            Answer = new List<bool> { true };
            Verify = UnitTest.CamelMatch(Queries, Pattern);
            Assert.AreEqual(true, Enumerable.SequenceEqual(Answer, Verify));
        }
    }
}