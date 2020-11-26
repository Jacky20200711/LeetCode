using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q3_Longest_Substring_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3_Longest_Substring_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            Program UnitTest = new Program();

            Assert.AreEqual(3, UnitTest.LengthOfLongestSubstring("abcabcbb"));
            Assert.AreEqual(1, UnitTest.LengthOfLongestSubstring("bbbbb"));
            Assert.AreEqual(3, UnitTest.LengthOfLongestSubstring("pwwkew"));
            Assert.AreEqual(0, UnitTest.LengthOfLongestSubstring(""));
            Assert.AreEqual(7, UnitTest.LengthOfLongestSubstring("axbcdbcdexyz"));
            Assert.AreEqual(1, UnitTest.LengthOfLongestSubstring("a"));
            Assert.AreEqual(5, UnitTest.LengthOfLongestSubstring("tmmzuxt"));
        }
    }
}