using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class LevelOrderBTTII
    {
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if(root == null) return new List<IList<int>>();

            List<IList<int>> result = new List<IList<int>>();
            List<int> pair = new List<int>();
            var queue = new Queue<TreeNode>();

            var temp = root;
            queue.Enqueue(temp);
            queue.Enqueue(new TreeNode(12345678));
            while (queue.Count != 0)
            {
                temp = queue.Dequeue();
                if (temp.val == 12345678)
                {
                    if (pair.Count != 0)
                    {
                        result.Insert(0, pair);
                        pair = new List<int>();
                    }

                }
                else
                {
                    pair.Add(temp.val);
                    if (temp.left != null)
                        queue.Enqueue(temp.left);
                    if (temp.right != null)
                        queue.Enqueue(temp.right);
                    queue.Enqueue(new TreeNode(12345678));
                }
            }
            return result;
        }
    }
}
