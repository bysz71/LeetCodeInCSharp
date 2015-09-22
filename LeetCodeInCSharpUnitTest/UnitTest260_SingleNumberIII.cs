using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest260_SingleNumberIII
    {
        [TestMethod]
        public void TestMethodSingleNumber()
        {
            var array = new int[] { 1, 2, 3, 4, 6, 1, 2, 3 };
            var result = SingleNumberIIISolution.SingleNumber(array);
            foreach (int i in result)
            {
                Console.Write(i + ",");
            }
        }
    }
}
