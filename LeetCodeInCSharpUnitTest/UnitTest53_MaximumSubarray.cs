using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest53_MaximumSubarray
    {
        [TestMethod]
        public void TestMethodMaxSubArray()
        {
            var nums1 = new int[] { 1, -1, 1, -1, 1, -1 };
            var nums2 = new int[] { 1, -2, 3, -4, 5 };
            var nums3 = new int[] { 1, 2, 2 , 2 , -5, 4, -7, 6};
            Assert.AreEqual(1, MaxSubArraySolution.MaxSubArray(nums1));
            Assert.AreEqual(5, MaxSubArraySolution.MaxSubArray(nums2));
            Assert.AreEqual(7, MaxSubArraySolution.MaxSubArray(nums3));
        }
    }
}
