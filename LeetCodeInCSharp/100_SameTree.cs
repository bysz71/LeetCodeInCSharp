using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Given two binary trees, write a function to check if they are equal or not.
//Two binary trees are considered equal if they are structurally identical and the nodes have the same value.

namespace LeetCodeInCSharp
{
    public class SameTreeSolution
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if ((p != null && q == null) || (p == null && q != null))
                return false;
            else if (p.val != q.val)
                return false;
            else
                return IsSameTree(p.left, q.left) == true && IsSameTree(p.right, q.right) == true;
        }
    }
}
