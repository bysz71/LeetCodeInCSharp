using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest258_AddDigits
    {
        [TestMethod]
        public void TestMethodAddDigits()
        {
            Assert.AreEqual(6, AddDigitsSolution.AddDigits(12345));
            Assert.AreEqual(0, AddDigitsSolution.AddDigits(0));
            Assert.AreEqual(9, AddDigitsSolution.AddDigits(999999));
            Assert.AreEqual(2, AddDigitsSolution.AddDigits(11));
        }
    }
}
