using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest242_ValidAnagram
    {
        [TestMethod]
        public void TestMethodIsAnagram()
        {
            string s1 = "aacc";
            string t1 = "ccac";
            Assert.AreEqual(false, ValidAnagramSolution.IsAnagram(s1, t1));
        }

        [TestMethod]
        public void TestMethodIsAnagram2()
        {
            string s1 = "aacc";
            string t1 = "ccac";
            Assert.AreEqual(false, ValidAnagramSolution.IsAnagram2(s1, t1));
        }
    }
}
