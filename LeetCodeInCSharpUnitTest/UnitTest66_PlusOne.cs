using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest66_PlusOne
    {
        [TestMethod]
        public void TestMethodPlusOne()
        {
            int[] test1 = new int[]{9,9,9};
            int[] test2 = new int[] { 1,0,2,3,4,8,9,9,9 };
            var result1 = PlusOneSolution.PlusOne(test1);
            var result2 = PlusOneSolution.PlusOne(test2);

            CollectionAssert.AreEqual(new int[] { 1, 0, 0, 0 }, result1);
            CollectionAssert.AreEqual(new int[] { 1, 0, 2, 3, 4, 9, 0, 0, 0 }, result2);
        }
    }
}
