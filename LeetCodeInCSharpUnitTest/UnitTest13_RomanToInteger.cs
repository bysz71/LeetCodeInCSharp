using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest13_RomanToInteger
    {
        [TestMethod]
        public void TestMethodRomanToInt()
        {
            var list = new Dictionary<int, string>();
            list[1] = "I";
            list[2] = "II";
            list[3] = "III";
            list[4] = "IV";
            list[5] = "V";
            list[6] = "VI";
            list[7] = "VII";
            list[8] = "VIII";
            list[9] = "IX";
            list[10] = "X";
            list[14] = "XIV";
            list[19] = "XIX";
            list[20] = "XX";
            list[49] = "XLIX";
            list[50] = "L";
            list[99] = "XCIX";
            list[100] = "C";
            list[499] = "CDXCIX";
            list[500] = "D";
            list[999] = "CMXCIX";
            list[1000] = "M";
            list[3999] = "MMMCMXCIX";
            foreach (var pair in list)
                Assert.AreEqual(pair.Key, RomanToIntSolution.RomanToInt(pair.Value));
        }

        [TestMethod]
        public void TestMethodRomanToInt2()
        {
            var list = new Dictionary<int, string>();
            list[1] = "I";
            list[2] = "II";
            list[3] = "III";
            list[4] = "IV";
            list[5] = "V";
            list[6] = "VI";
            list[7] = "VII";
            list[8] = "VIII";
            list[9] = "IX";
            list[10] = "X";
            list[14] = "XIV";
            list[19] = "XIX";
            list[20] = "XX";
            list[49] = "XLIX";
            list[50] = "L";
            list[99] = "XCIX";
            list[100] = "C";
            list[499] = "CDXCIX";
            list[500] = "D";
            list[999] = "CMXCIX";
            list[1000] = "M";
            list[3999] = "MMMCMXCIX";
            foreach (var pair in list)
                Assert.AreEqual(pair.Key, RomanToIntSolution.RomanToInt2(pair.Value));
        }
    }
}
