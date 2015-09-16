using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest104_MaximumDepthOfABinaryTree
    {
        [TestMethod]
        public void TestMethodMaxDepth()
        {
            var tree = new TreeNode(0);
            tree.left = new TreeNode(1);
            tree.right = new TreeNode(1);
            tree.left.left = new TreeNode(2);
            tree.left.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(2);

            int depth = MaximumDepthOfABinaryTree.MaxDepth(tree);
            Assert.AreEqual(4, depth);
        }
    }
}
