using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q692_Top_K_Frequent_Words_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q692_Top_K_Frequent_Words_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public void PrintContent(IList<string> StrList)
        {
            foreach (string str in StrList)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
        }

        [TestMethod()]
        public void TopKFrequentTest()
        {
            Program UnitTest = new Program();
            IList<string> verify, answer;
            string[] words;

            words = new string[]{ "i", "love", "leetcode", "i", "love", "coding" };
            verify = UnitTest.TopKFrequent(words, 2);
            answer = new List<string>{ "i", "love" };
            Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));

            words = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            verify = UnitTest.TopKFrequent(words, 4);
            answer = new List<string> { "the", "is", "sunny", "day" };
            Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));

            words = new string[] { "cc", "bb", "cc", "aa", "bb", "aa" };
            verify = UnitTest.TopKFrequent(words, 3);
            answer = new List<string> { "aa", "bb", "cc" };
            Assert.AreEqual(true, Enumerable.SequenceEqual(answer, verify));
        }
    }
}