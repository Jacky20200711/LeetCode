using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q208_Implement_Trie_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q208_Implement_Trie_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetTrieTest()
        {
            Program UnitTest = new Program();
            Program.Trie trie = UnitTest.GetTrie();

            trie.Insert("apple");
            Assert.AreEqual(true, trie.Search("apple"));
            Assert.AreEqual(false, trie.Search("app"));
            Assert.AreEqual(true, trie.StartsWith("app"));
            trie.Insert("app");
            Assert.AreEqual(true, trie.Search("app"));
            Assert.AreEqual(false, trie.Search("appl"));
            Assert.AreEqual(true, trie.StartsWith("appl"));
            Assert.AreEqual(false, trie.Search("bbc"));
            Assert.AreEqual(false, trie.StartsWith("bbc"));
            trie.Insert("bbc");
            Assert.AreEqual(true, trie.Search("bbc"));
            Assert.AreEqual(true, trie.StartsWith("bbc"));
        }
    }
}