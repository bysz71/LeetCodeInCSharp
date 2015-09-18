using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class LCASolution
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode small, large;
            if (p.val < q.val)
            {
                small = p;
                large = q;
            }
            else
            {
                small = q;
                large = p;
            }

            var temp = root;
            while (!(temp.val >= small.val && temp.val <= large.val))
            {
                if (temp.val < small.val)
                    temp = temp.right;
                else
                    temp = temp.left;
            }
            return temp;
        }
    }
}
