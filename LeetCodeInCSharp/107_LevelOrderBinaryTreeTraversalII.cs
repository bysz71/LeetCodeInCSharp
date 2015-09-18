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
            List<int> level = new List<int>();
            var queue = new Queue<NodeWithHeight>();
            int height = 0;
            var temp = new NodeWithHeight(root,height);
            queue.Enqueue(temp);
            while(queue.Count != 0){
                temp = queue.Dequeue();
                if (temp.Height > height)
                {
                    result.Insert(0, level);
                    height = temp.Height;
                    level = new List<int>();
                    level.Add(temp.Node.val);
                }
                else
                    level.Add(temp.Node.val);
                if (temp.Node.left != null)
                    queue.Enqueue(new NodeWithHeight(temp.Node.left, temp.Height + 1));
                if (temp.Node.right != null)
                    queue.Enqueue(new NodeWithHeight(temp.Node.right, temp.Height + 1));
            }
            if (level.Count != 0)
                result.Insert(0, level);
            return result;
        }
    }

    public class NodeWithHeight
    {
        public TreeNode Node{get; private set;}
        public int Height { get; private set;}
        public NodeWithHeight(TreeNode node, int height)
        {
            Node = node;
            Height = height;
        }
    }
}
