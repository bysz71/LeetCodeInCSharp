using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest171_ExcelSheetColumnNumber
    {
        [TestMethod]
        public void TestMethodTitleToNumber()
        {
            string title1 = "A";
            string title2 = "Z";
            string title3 = "AA";

            Assert.AreEqual(1, TitleToNumberSolution.TitleToNumber(title1));
            Assert.AreEqual(26, TitleToNumberSolution.TitleToNumber(title2));
            Assert.AreEqual(27, TitleToNumberSolution.TitleToNumber(title3));
        }
    }
}
