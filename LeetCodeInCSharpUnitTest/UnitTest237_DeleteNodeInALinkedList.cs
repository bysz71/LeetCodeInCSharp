using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class UnitTest237_DeleteNodeInALinkedList
    {
        [TestMethod]
        public void TestMethodDeleteNode()
        {
            //generate a linkedList 1 -> 2 -> 3 -> 4
            var linkedList = new ListNode(1);
            var buffer = linkedList;
            for (int i = 2; i < 5; i++)
            {
                buffer.next = new ListNode(i);
                buffer = buffer.next;
            }

            //select the node with value 3
            buffer = linkedList.next.next;
            Console.WriteLine(buffer.val);
            DeleteNodeInALinkedList.DeleteNode(buffer);

            //s
            Assert.AreEqual(1, linkedList.val);
            Assert.AreEqual(2, linkedList.next.val);
            Assert.AreEqual(4, linkedList.next.next.val);
            Assert.AreEqual(null, linkedList.next.next.next);
        }
    }
}
