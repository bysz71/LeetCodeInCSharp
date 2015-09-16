using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
