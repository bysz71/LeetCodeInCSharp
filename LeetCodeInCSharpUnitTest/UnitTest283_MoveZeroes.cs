using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest283_MoveZeroes
    {
        [TestMethod]
        public void TestMethodMoveZeroes()
        {
            var array = new int[] { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5, 0, 6, 0 };
            MoveZeroesSolution.MoveZeroes(array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0 }, array);
        }
    }
}
