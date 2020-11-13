using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q49_Group_Anagrams_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q49_Group_Anagrams_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            Program UnitTest = new Program();
            // --------------------------------------------------------------------------
            string[] Sample = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> Tester = UnitTest.GroupAnagrams(Sample);
            IList<IList<string>> Answer = new List<IList<string>>()
            {
                new List<string>
                {
                    "eat", "tea", "ate"
                },

                new List<string>
                {
                    "tan", "nat"
                },

                new List<string>
                {
                    "bat"
                },
            };

            for(int i = 0; i < Answer.Count; i++)
            {
                Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));
            }
            // --------------------------------------------------------------------------
            Sample = new string[] { "" };
            Tester = UnitTest.GroupAnagrams(Sample);
            Answer = new List<IList<string>>()
            {
                new List<string>
                {
                    ""
                },
            };

            for (int i = 0; i < Answer.Count; i++)
            {
                Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));
            }
            // --------------------------------------------------------------------------
            Sample = new string[] { "a" };
            Tester = UnitTest.GroupAnagrams(Sample);
            Answer = new List<IList<string>>()
            {
                new List<string>
                {
                    "a"
                },
            };

            for (int i = 0; i < Answer.Count; i++)
            {
                Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));
            }
            // --------------------------------------------------------------------------
            Sample = new string[] { "eat", "eat", "eat" };
            Tester = UnitTest.GroupAnagrams(Sample);
            Answer = new List<IList<string>>()
            {
                new List<string>
                {
                    "eat", "eat", "eat"
                },
            };

            for (int i = 0; i < Answer.Count; i++)
            {
                Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));
            }
            // --------------------------------------------------------------------------
            Sample = new string[] { "aba", "aaa", "baa", "aaa", "aab" };
            Tester = UnitTest.GroupAnagrams(Sample);
            Answer = new List<IList<string>>()
            {
                new List<string>
                {
                    "aba", "baa", "aab"
                },

                new List<string>
                {
                    "aaa", "aaa"
                },
            };

            for (int i = 0; i < Answer.Count; i++)
            {
                Assert.AreEqual(true, Enumerable.SequenceEqual(Tester[i], Answer[i]));
            }
            // --------------------------------------------------------------------------
        }
    }
}