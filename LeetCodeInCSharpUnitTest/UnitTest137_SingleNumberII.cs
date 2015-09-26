using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest137_SingleNumberII
    {
        [TestMethod]
        public void TestMethodSingleNumber()
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 5, 5 };
            Assert.AreEqual(3, SingleNumberIISolution.SingleNumber(nums));
        }
    }
}
