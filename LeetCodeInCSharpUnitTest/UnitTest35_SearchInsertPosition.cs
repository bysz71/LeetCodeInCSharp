using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest35_SearchInsertPosition
    {
        [TestMethod]
        public void TestMethodSearchInsert()
        {
            var arr1 = new int[] { 1 };
            var res = SearchInsertSolution.SearchInsert(arr1, 0);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodSearchInseartBinary()
        {
            var arr1 = new int[] { 1 };
            var res1 = SearchInsertSolution.SearchInsertBinary(arr1, 0);
            var res2 = SearchInsertSolution.SearchInsertBinary(arr1, 2);
            Assert.AreEqual(0, res1);
            Assert.AreEqual(1, res2);
            var arr2 = new int[] { 1, 3, 5, 7 };
            var res3 = SearchInsertSolution.SearchInsertBinary(arr2, 0);
            Assert.AreEqual(0, res3);
            var res4 = SearchInsertSolution.SearchInsertBinary(arr2, 3);
            Assert.AreEqual(1, res4);
            var res5 = SearchInsertSolution.SearchInsertBinary(arr2, 4);
            Assert.AreEqual(2, res5);
            var res6 = SearchInsertSolution.SearchInsertBinary(arr2, 8);
            Assert.AreEqual(4, res6);
        }
    }
}
