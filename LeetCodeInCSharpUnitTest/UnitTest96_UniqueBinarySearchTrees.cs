using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest96_UniqueBinarySearchTrees
    {
        [TestMethod]
        public void TestMethodNumTrees()
        {
            Assert.AreEqual(1, UniqueBinarySearchTreesSolution.NumTrees(1));
            Assert.AreEqual(2, UniqueBinarySearchTreesSolution.NumTrees(2));
            Assert.AreEqual(5, UniqueBinarySearchTreesSolution.NumTrees(3));
        }
    }
}
