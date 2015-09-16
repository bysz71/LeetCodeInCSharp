using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest226_InverBinaryTree
    {
        [TestMethod]
        public void TestMethodInvertTree()
        {
            var tree = new TreeNode(10);
            tree.left = new TreeNode(8);
            tree.right = new TreeNode(12);
            tree.left.left = new TreeNode(7);
            tree.left.right = new TreeNode(9);

            tree = InvertBinaryTreeSolution.InvertTree(tree);

            Assert.AreEqual(10, tree.val);
            Assert.AreEqual(8, tree.right.val);
            Assert.AreEqual(12, tree.left.val);
            Assert.AreEqual(7, tree.right.right.val);
            Assert.AreEqual(9, tree.right.left.val);
        }
    }
}
