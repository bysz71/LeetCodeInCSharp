using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest144_BinaryTreePreOrderTraversal
    {
        [TestMethod]
        public void TestMethodPreOrderTraversal()
        {
            var tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.right.left = new TreeNode(4);
            tree.right.right = new TreeNode(5);

            IList<int> list = new List<int> { 1, 2, 3, 4, 5 };

            for (int i = 0; i < PreOrderTraversalSolution.PreorderTraversal(tree).Count; i++)
            {
                Assert.AreEqual(i + 1, PreOrderTraversalSolution.PreorderTraversal(tree)[i]);
            }

            for (int i = 0; i < PreOrderTraversalSolution.StackPreorderTraversal(tree).Count; i++)
            {
                Assert.AreEqual(i + 1, PreOrderTraversalSolution.StackPreorderTraversal(tree)[i]);
            }
        }
    }
}
