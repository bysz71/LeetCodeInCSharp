using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class UnitTest28_ImplementStrStr
    {
        [TestMethod]
        public void TestMethodStrStr()
        {
            string haystack = "This is an interesting problem.";
            string needle1 = "";
            string needle2 = " int";
            string needle3 = "probleem";

            Assert.AreEqual(0, ImplementStrStr.StrStr(haystack, needle1));
            Assert.AreEqual(10, ImplementStrStr.StrStr(haystack, needle2));
            Assert.AreEqual(-1, ImplementStrStr.StrStr(haystack, needle3));
        }
    }
}
