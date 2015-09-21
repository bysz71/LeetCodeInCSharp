using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTest94_BinaryTreeInOrderTraversal
    {
        [TestMethod]
        public void TestMethodInorderTraversal()
        {
            var tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.right.left = new TreeNode(4);
            tree.right.right = new TreeNode(5);

            IList<int> list = new List<int> { 2, 1, 4, 3, 5 };
            for (int i = 0; i < InOrderTraversalSolution.InorderTraversal(tree).Count; i++)
            {
                Assert.AreEqual(list[i], InOrderTraversalSolution.InorderTraversal(tree)[i]);
            }
            for (int i = 0; i < InOrderTraversalSolution.StackInorderTraversal(tree).Count; i++)
            {
                Assert.AreEqual(list[i], InOrderTraversalSolution.StackInorderTraversal(tree)[i]);
            }
        }
    }
}
