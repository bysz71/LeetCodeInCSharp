using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Invert a binary tree

namespace LeetCodeInCSharp
{
    public class InvertBinaryTreeSolution
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var buffer = root.left;
            root.left = root.right;
            root.right = buffer;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}
