using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q745_Prefix_and_Suffix_Search_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q745_Prefix_and_Suffix_Search_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetWordFilterTest()
        {
            Program UnitTest = new Program();
            Program.WordFilter wordFilter;
            string[] words;

            words = new string[] { "apple" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(0, wordFilter.F("a", "e"));

            words = new string[] { "apple" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(-1, wordFilter.F("x", "y"));

            words = new string[] { "apple", "apple", "apple" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(2, wordFilter.F("a", "e"));

            words = new string[] { "apple", "applee", "appleee" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(2, wordFilter.F("a", "e"));

            words = new string[] { "bird" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(0, wordFilter.F("bird", "bird"));

            words = new string[] { "cabaabaaaa", "ccbcababac", "bacaabccba", "bcbbcbacaa", "abcaccbcaa", "accabaccaa", "cabcbbbcca", "ababccabcb", "caccbbcbab", "bccbacbcba" };
            wordFilter = UnitTest.GetWordFilter(words);
            Assert.AreEqual(9, wordFilter.F("bccbacbcba", "a"));
            Assert.AreEqual(4, wordFilter.F("ab", "abcaccbcaa"));
            Assert.AreEqual(5, wordFilter.F("a", "aa"));
            Assert.AreEqual(0, wordFilter.F("cabaaba", "abaaaa"));
            Assert.AreEqual(8, wordFilter.F("cacc", "accbbcbab"));
            Assert.AreEqual(1, wordFilter.F("ccbcab", "bac"));
            Assert.AreEqual(2, wordFilter.F("bac", "cba"));
            Assert.AreEqual(5, wordFilter.F("ac", "accabaccaa"));
            Assert.AreEqual(3, wordFilter.F("bcbb", "aa"));
            Assert.AreEqual(1, wordFilter.F("ccbca", "cbcababac"));
        }
    }
}