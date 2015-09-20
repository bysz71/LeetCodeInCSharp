using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest217_ContainsDuplicate
    {
        [TestMethod]
        public void TestMethodContainsDuplicate()
        {
            var test1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var test2 = new int[] { 1, 2, 3, 3, 4, 5, 6, 7 };
            Assert.AreEqual(false, ContainsDuplicateSolution.ContainsDuplicate(test1));
            Assert.AreEqual(true, ContainsDuplicateSolution.ContainsDuplicate(test2));
        }
    }
}
