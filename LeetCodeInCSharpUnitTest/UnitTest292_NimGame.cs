using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest292_NimGame
    {
        [TestMethod]
        public void TestMethod1CanWinNim()
        {
            int g1 = 10;
            int g2 = 1;
            int g3 = 4;
            Assert.AreEqual(true, NimGameSolution.CanWinNim(g1));
            Assert.AreEqual(true, NimGameSolution.CanWinNim(g2));
            Assert.AreEqual(false, NimGameSolution.CanWinNim(g3));
        }
    }
}
