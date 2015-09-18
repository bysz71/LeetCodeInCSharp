using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeInCSharp;

namespace LeetCodeInCSharpUnitTest
{
    [TestClass]
    public class UnitTestLevelOrderBottom
    {
        [TestMethod]
        public void TestMethodLevelOrderBottom()
        {
            var tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var list = LevelOrderBTTII.LevelOrderBottom(tree);
            Assert.AreEqual(15, list[0][0]);
            Assert.AreEqual(7, list[0][1]);
            Assert.AreEqual(9, list[1][0]);
            Assert.AreEqual(20, list[1][1]);
            Assert.AreEqual(3, list[2][0]);

            var tree2 = new TreeNode(1);
            tree2.left = new TreeNode(2);
            var list2 = LevelOrderBTTII.LevelOrderBottom(tree2);
        }
    }
}
