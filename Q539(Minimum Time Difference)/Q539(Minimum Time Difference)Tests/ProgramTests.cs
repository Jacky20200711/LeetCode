using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q539_Minimum_Time_Difference_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q539_Minimum_Time_Difference_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FindMinDifferenceTest()
        {
            Program UnitTest = new Program();
            IList<string> timePoints;

            timePoints = new List<string> { "23:59", "00:00" };
            Assert.AreEqual(1, UnitTest.FindMinDifference(timePoints));

            timePoints = new List<string> { "00:00", "23:59", "00:00" };
            Assert.AreEqual(0, UnitTest.FindMinDifference(timePoints));

            timePoints = new List<string> { "00:00", "23:59", "00:05" };
            Assert.AreEqual(1, UnitTest.FindMinDifference(timePoints));

            timePoints = new List<string> { "00:00", "00:55", "00:00" };
            Assert.AreEqual(0, UnitTest.FindMinDifference(timePoints));

            timePoints = new List<string> { "12:12", "00:13" };
            Assert.AreEqual(719, UnitTest.FindMinDifference(timePoints));
        }
    }
}