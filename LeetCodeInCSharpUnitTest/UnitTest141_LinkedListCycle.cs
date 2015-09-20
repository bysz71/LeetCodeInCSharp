using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest141_LinkedListCycle
    {
        [TestMethod]
        public void TestMethodHasCycle()
        {
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            var cycleNode = new ListNode(4);
            list.next.next.next = cycleNode;
            list.next.next.next.next = new ListNode(5);
            list.next.next.next.next.next = new ListNode(6);
            list.next.next.next.next.next.next = cycleNode;

            Assert.AreEqual(true, HasCycleSolution.HasCycle(list));
        }
    }
}
