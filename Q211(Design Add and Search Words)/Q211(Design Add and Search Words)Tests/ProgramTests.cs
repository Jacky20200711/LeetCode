using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q211_Design_Add_and_Search_Words_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q211_Design_Add_and_Search_Words_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetTrieTest()
        {
            Program UnitTest = new Program();
            Program.WordDictionary wordDictionary = UnitTest.GetTrie();

            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");

            Assert.AreEqual(false, wordDictionary.Search("pad"));
            Assert.AreEqual(true, wordDictionary.Search("bad"));
            Assert.AreEqual(true, wordDictionary.Search(".ad"));
            Assert.AreEqual(true, wordDictionary.Search("b.."));
            Assert.AreEqual(true, wordDictionary.Search("..."));
            Assert.AreEqual(true, wordDictionary.Search("..d"));
            Assert.AreEqual(false, wordDictionary.Search("...."));
            Assert.AreEqual(false, wordDictionary.Search(".."));
        }
    }
}