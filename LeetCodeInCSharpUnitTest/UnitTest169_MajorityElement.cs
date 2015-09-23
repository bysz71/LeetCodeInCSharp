using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest169_MajorityElement
    {
        [TestMethod]
        public void TestMethodMajorityElement()
        {
            int[] list = new int[] { 1, 2, 1, 3, 1, 4, 1, 5, 1, 6, 1, 1, 1 };
            Assert.AreEqual(1, MajorityElementSolution.MajoirityElement(list));
        }

        [TestMethod]
        public void TestMethodMajorityElement2()
        {
            int[] list = new int[] { 1, 2, 1, 3, 1, 4, 1, 5, 1, 6, 1, 1, 1 };
            Assert.AreEqual(1, MajorityElementSolution.MajoirityElement2(list));
        }
    }
}
