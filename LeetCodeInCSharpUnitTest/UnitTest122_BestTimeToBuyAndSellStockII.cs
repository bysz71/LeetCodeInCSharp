using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMaxProfit()
        {
            int[] prices = new int[20] { 1, 3, 9, 5, 3, 1, 3, 5, 3, 9, 7, 9, 3, 7, 5, 1, 3, 9, 9, 7 };
            int maxProfit = StockTradeII.MaxProfit(prices);
            Assert.AreEqual(32, maxProfit);
        }
    }
}
