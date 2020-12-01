using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q648_Replace_Words_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q648_Replace_Words_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ReplaceWordsTest()
        {
            Program UnitTest = new Program();
            List<string> dictionary;
            string sentence;

            dictionary = new List<string> { "cat", "bat", "rat" };
            sentence = "the cattle was rattled by the battery";
            Assert.AreEqual("the cat was rat by the bat", UnitTest.ReplaceWords(dictionary, sentence));

            dictionary = new List<string> { "a", "b", "c" };
            sentence = "aadsfasf absbs bbab cadsfafs";
            Assert.AreEqual("a a b c", UnitTest.ReplaceWords(dictionary, sentence));

            dictionary = new List<string> { "a", "aa", "aaa", "aaaa" };
            sentence = "a aa a aaaa aaa aaa aaa aaaaaa bbb baba ababa";
            Assert.AreEqual("a a a a a a a a bbb baba a", UnitTest.ReplaceWords(dictionary, sentence));

            dictionary = new List<string> { "catt", "cat", "bat", "rat" };
            sentence = "the cattle was rattled by the battery";
            Assert.AreEqual("the cat was rat by the bat", UnitTest.ReplaceWords(dictionary, sentence));

            dictionary = new List<string> { "ac", "ab" };
            sentence = "it is abnormal that this solution is accepted";
            Assert.AreEqual("it is ab that this solution is ac", UnitTest.ReplaceWords(dictionary, sentence));
        }
    }
}