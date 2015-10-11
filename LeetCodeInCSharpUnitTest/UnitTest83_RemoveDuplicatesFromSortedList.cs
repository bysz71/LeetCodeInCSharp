using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest83_RemoveDuplicatesFromSortedList
    {
        [TestMethod]
        public void TestMethodDeleteDuplicates()
        {
            var list = new ListNode(0);
            list.next = new ListNode(1);
            list.next.next = new ListNode(1);
            list.next.next.next = new ListNode(2);
            list.next.next.next.next = new ListNode(2);

            list = DeleteDuplicatesSolution.DeleteDuplicates(list);
            Assert.AreEqual(2, list.next.next.val);
            Assert.AreEqual(null, list.next.next.next);
        }
    }
}
