using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest136_SingleNumber
    {
        [TestMethod]
        public void TestMethodSingleNumber()
        {

            int[] nums = new int[]{1, 3, 9, 5, 4, 6, 5, 3, 1, 9, 4};
            int singleNumber = SingleNumberClass.SingleNumber(nums);
            Assert.AreEqual(6, singleNumber);
        }
    }
}
