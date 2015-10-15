using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest70_ClimbingStairs
    {
        [TestMethod]
        public void TestMethodClimbStairs()
        {
            Assert.AreEqual(1, ClimbStairsSolution.ClimbStairs(1));
            Assert.AreEqual(2, ClimbStairsSolution.ClimbStairs(2));
            Assert.AreEqual(3, ClimbStairsSolution.ClimbStairs(3));
            Assert.AreEqual(5, ClimbStairsSolution.ClimbStairs(4));
            Assert.AreEqual(8, ClimbStairsSolution.ClimbStairs(5));
            Assert.AreEqual(13, ClimbStairsSolution.ClimbStairs(6));
            Assert.AreEqual(21, ClimbStairsSolution.ClimbStairs(7));
            Assert.AreEqual(34, ClimbStairsSolution.ClimbStairs(8));
            Assert.AreEqual(55, ClimbStairsSolution.ClimbStairs(9));
        }

        [TestMethod]
        public void TestMethodClimbStairsNoRecursive()
        {
            Assert.AreEqual(1, ClimbStairsSolution.ClimbStairsNoRecursive(1));
            Assert.AreEqual(2, ClimbStairsSolution.ClimbStairsNoRecursive(2));
            Assert.AreEqual(3, ClimbStairsSolution.ClimbStairsNoRecursive(3));
            Assert.AreEqual(5, ClimbStairsSolution.ClimbStairsNoRecursive(4));
            Assert.AreEqual(8, ClimbStairsSolution.ClimbStairsNoRecursive(5));
            Assert.AreEqual(13, ClimbStairsSolution.ClimbStairsNoRecursive(6));
            Assert.AreEqual(21, ClimbStairsSolution.ClimbStairsNoRecursive(7));
            Assert.AreEqual(34, ClimbStairsSolution.ClimbStairsNoRecursive(8));
            Assert.AreEqual(55, ClimbStairsSolution.ClimbStairsNoRecursive(9));
        }
    }
}
