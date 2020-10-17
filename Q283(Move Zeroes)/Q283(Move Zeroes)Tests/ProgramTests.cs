using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q283_Move_Zeroes_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q283_Move_Zeroes_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            Program testClass = new Program();

            int[] arr1, arr2;

            arr1 = new int[] {};
            arr2 = new int[] {};
            Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));

            arr1 = new int[] { 1,2 };
            arr2 = new int[] { 1,2 };
            Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));

            arr1 = new int[] { 0,0,0,1,2 };
            arr2 = new int[] { 1,2,0,0,0 };
            Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));

            arr1 = new int[] { 0, 1, 0, 3, 12 };
            arr2 = new int[] { 1, 3, 12, 0, 0 };
            Assert.AreEqual(true, testClass.MoveZeroes(arr1, arr2));
        }
    }
}