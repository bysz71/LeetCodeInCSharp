using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest116_PopulatingNextRightPointersInEachNode
    {
        [TestMethod]
        public void TestMethodConnectQueue()
        {
            var tree = new TreeLinkNode(0);
            tree.left = new TreeLinkNode(1);
            tree.right = new TreeLinkNode(2);
            tree.left.left = new TreeLinkNode(3);
            tree.left.right = new TreeLinkNode(4);
            tree.right.left = new TreeLinkNode(5);
            tree.right.right = new TreeLinkNode(6);

            ConnectSolution.ConnectQueue(tree);
            Assert.AreEqual("[0,#,1,2,#,3,4,5,6,#]", tree.ToString());
        }

        [TestMethod]
        public void TestMethodConnectRecursive()
        {
            var tree = new TreeLinkNode(0);
            tree.left = new TreeLinkNode(1);
            tree.right = new TreeLinkNode(2);
            tree.left.left = new TreeLinkNode(3);
            tree.left.right = new TreeLinkNode(4);
            tree.right.left = new TreeLinkNode(5);
            tree.right.right = new TreeLinkNode(6);

            ConnectSolution.ConnectRecursive(tree);
            Assert.AreEqual("[0,#,1,2,#,3,4,5,6,#]", tree.ToString());
        }
    }
}
