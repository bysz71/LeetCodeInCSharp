using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest12_IntegerToRoman
    {
        [TestMethod]
        public void TestMethodIntToRoman()
        {
            Assert.AreEqual("MMMCMXCIX", IntToRomanSolution.IntToRoman(3999));
        }

        [TestMethod]
        public void TestMethodIntToRoman2()
        {
            Assert.AreEqual("MMMCMXCIX", IntToRomanSolution.IntToRoman2(3999));
        }
    }
}
