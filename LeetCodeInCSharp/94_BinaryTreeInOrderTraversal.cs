using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class InOrderTraversalSolution
    {
        //recursive solution
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            list.AddRange(InorderTraversal(root.left));
            list.Add(root.val);
            list.AddRange(InorderTraversal(root.right));
            return list;
        }

        //stack iteration solution
        public static IList<int> StackInorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            var stack = new Stack<TreeNode>();
            var temp = root;
            while (temp != null)
            {
                while (temp != null)
                {
                    if (temp.right != null)
                        stack.Push(temp.right);
                    stack.Push(temp);
                    temp = temp.left;
                }

                temp = stack.Pop();

                while (stack.Count != 0 && temp.right == null)
                {
                    list.Add(temp.val);
                    temp = stack.Pop();
                }

                list.Add(temp.val);

                if (stack.Count != 0)
                    temp = stack.Pop();
                else
                    temp = null;
            }
            return list;
        }
    }
}
