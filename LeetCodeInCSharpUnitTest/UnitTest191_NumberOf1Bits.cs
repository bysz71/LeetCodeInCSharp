using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest191_NumberOf1Bits
    {
        [TestMethod]
        public void TestMethodHammingWeight()
        {
            uint a = 0;
            uint b = 1;
            uint c = 2;
            uint d = 100;

            Assert.AreEqual(0, HammingWeightSolution.HammingWeight(a));
            Assert.AreEqual(1, HammingWeightSolution.HammingWeight(b));
            Assert.AreEqual(1, HammingWeightSolution.HammingWeight(c));
            Assert.AreEqual(3, HammingWeightSolution.HammingWeight(d));
        }
    }
}
