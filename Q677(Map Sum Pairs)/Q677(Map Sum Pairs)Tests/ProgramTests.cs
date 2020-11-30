using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q677_Map_Sum_Pairs_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q677_Map_Sum_Pairs_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetTrieTest()
        {
            Program UnitTest = new Program();
            Program.MapSum mapSum = UnitTest.GetTrie();

            mapSum.Insert("apple", 3);
            Assert.AreEqual(0, mapSum.Sum("b"));
            Assert.AreEqual(3, mapSum.Sum("ap"));
            mapSum.Insert("app", 2);
            Assert.AreEqual(5, mapSum.Sum("ap"));
            mapSum.Insert("apple", 1);
            Assert.AreEqual(1, mapSum.Sum("apple"));
        }
    }
}