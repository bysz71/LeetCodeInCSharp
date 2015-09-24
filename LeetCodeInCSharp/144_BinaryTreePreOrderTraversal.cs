using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class PreOrderTraversalSolution
    {
        /// <summary>
        /// The recursive way
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();
            else return new List<int>() { root.val }
                    .Concat(PreorderTraversal(root.left))
                    .Concat(PreorderTraversal(root.right))
                    .ToList();
        }

        /// <summary>
        /// The stack solution
        /// </summary>
        /// <param name="root">Root node of the tree</param>
        /// <returns>A list of PreOrderTraversal of the tree</returns>
        public static IList<int> StackPreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            var stack = new Stack<TreeNode>();
            TreeNode temp;
            if (root != null) stack.Push(root);
            while (stack.Count != 0)
            {
                temp = stack.Pop();
                list.Add(temp.val);
                if(temp.right != null) stack.Push(temp.right);
                if(temp.left != null) stack.Push(temp.left);
            }
            return list;
        }
    }
}
