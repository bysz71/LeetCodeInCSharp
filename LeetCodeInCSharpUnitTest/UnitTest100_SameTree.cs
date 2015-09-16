using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest100_SameTree
    {
        [TestMethod]
        public void TestMethodIsSameTree()
        {
            var tree1 = new TreeNode(0);
            var tree2 = new TreeNode(0);
            var tree3 = new TreeNode(0);
            var tree4 = new TreeNode(1);

            tree1.left = new TreeNode(1);
            tree1.right = new TreeNode(1);
            tree1.left.left = new TreeNode(2);

            tree2.left = new TreeNode(1);
            tree2.right = new TreeNode(1);
            tree2.left.left = new TreeNode(2);

            tree3.left = new TreeNode(1);
            tree3.right = new TreeNode(1);
            tree3.left.right = new TreeNode(2);

            tree1.left = new TreeNode(1);
            tree1.right = new TreeNode(1);
            tree1.left.left = new TreeNode(2);

            Assert.AreEqual(true, SameTreeSolution.IsSameTree(tree1, tree2));
            Assert.AreEqual(false, SameTreeSolution.IsSameTree(tree1, tree3));
            Assert.AreEqual(false, SameTreeSolution.IsSameTree(tree1, tree4));

        }
    }
}
