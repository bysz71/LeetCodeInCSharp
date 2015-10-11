using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest235_LowestCommonAncestorOfABinarySearchTree
    {
        [TestMethod]
        public void TestMethodLowestCommonAncestor()
        {
            var tree0 = new TreeNode(20);
            tree0.left = new TreeNode(10);
            tree0.right = new TreeNode(30);
            tree0.left.left = new TreeNode(5);
            tree0.left.right = new TreeNode(15);
            tree0.right.left = new TreeNode(25);
            tree0.right.right = new TreeNode(35);
            tree0.left.left.left = new TreeNode(2);

            Assert.AreEqual(20, LCASolution.LowestCommonAncestor(tree0, tree0.left.left.left, tree0.right.right).val);
            Assert.AreEqual(5, LCASolution.LowestCommonAncestor(tree0, tree0.left.left.left, tree0.left.left).val);
        }
    }
}
