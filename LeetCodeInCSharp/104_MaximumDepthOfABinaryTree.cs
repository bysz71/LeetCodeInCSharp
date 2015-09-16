using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class MaximumDepthOfABinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
