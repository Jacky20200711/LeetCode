using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q93_Restore_IP_Addresses_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q93_Restore_IP_Addresses_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public bool CompareStrList(IList<string> Answer, IList<string> Verify)
        {
            if (Answer.Count != Verify.Count)
            {
                return false;
            }

            for (int i = 0; i < Answer.Count; i++)
            {
                if (Answer[i] != Verify[i])
                {
                    return false;
                }
            }

            return true;
        }

        [TestMethod()]
        public void RestoreIpAddressesTest()
        {
            Program UnitTest = new Program();
            IList<string> Answer, Verify;

            Answer = new List<string> { "255.255.11.135", "255.255.111.35" };
            Verify = UnitTest.RestoreIpAddresses("25525511135");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));

            Answer = new List<string> { "0.0.0.0" };
            Verify = UnitTest.RestoreIpAddresses("0000");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));

            Answer = new List<string> { "1.1.1.1" };
            Verify = UnitTest.RestoreIpAddresses("1111");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));

            Answer = new List<string> { "0.10.0.10", "0.100.1.0" };
            Verify = UnitTest.RestoreIpAddresses("010010");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));

            Answer = new List<string> { "1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3" };
            Verify = UnitTest.RestoreIpAddresses("101023");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));

            Answer = new List<string> { };
            Verify = UnitTest.RestoreIpAddresses("0");
            Assert.AreEqual(true, CompareStrList(Answer, Verify));
        }
    }
}