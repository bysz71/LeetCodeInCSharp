using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest168_ExcelSheetColumnTitle
    {
        [TestMethod]
        public void TestMethodConvertToTitle()
        {
            Assert.AreEqual("A", ConvertToTitleSolution.ConvertToTitle(1));
            Assert.AreEqual("Z", ConvertToTitleSolution.ConvertToTitle(26));
            Assert.AreEqual("AA", ConvertToTitleSolution.ConvertToTitle(27));
        }
    }
}
