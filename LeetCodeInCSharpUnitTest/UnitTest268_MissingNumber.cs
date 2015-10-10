using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest268_MissingNumber
    {
        [TestMethod]
        public void TestMethodMissingNumber()
        {
            int[] nums1 = new int[] { 1 };
            var nums2 = new int[] { 1, 0 };
            var nums3 = new int[] { 0, 2 };
            Assert.AreEqual(0, MissingNumberSolution.MissingNumber(nums1));
            Assert.AreEqual(2, MissingNumberSolution.MissingNumber(nums2));
            Assert.AreEqual(1, MissingNumberSolution.MissingNumber(nums3));
        }
    }
}
