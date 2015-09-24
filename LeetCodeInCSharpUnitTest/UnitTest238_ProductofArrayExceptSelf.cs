using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest238_ProductofArrayExceptSelf
    {
        [TestMethod]
        public void TestMethodProductExceptSelf()
        {
            var list1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var list2 = new int[] { 0, 0, 0 };
            CollectionAssert.AreEqual(
                new int[] { 720, 360, 240, 180, 144, 120 },
                ProductExceptSelfSolution.ProductExceptSelf(list1)
            );
            CollectionAssert.AreEqual(
                new int[] { 0, 0, 0 },
                ProductExceptSelfSolution.ProductExceptSelf(list2)
            );
        }
    }
}
