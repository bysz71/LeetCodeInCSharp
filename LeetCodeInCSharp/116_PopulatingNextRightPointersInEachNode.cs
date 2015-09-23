using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class TreeLinkNode
    {
        public int val;
        public TreeLinkNode left;
        public TreeLinkNode right;
        public TreeLinkNode next;
        public TreeLinkNode(int val)
        {
            this.val = val;
            left = right = next = null;
        }

        public override string ToString()
        {
            var list = new List<string>();
            var queue = new Queue<TreeLinkNode>();
            var temp = this;
            queue.Enqueue(temp);
            while (queue.Count != 0)
            {
                temp = queue.Dequeue();
                list.Add(temp.val.ToString());
                if (temp.next == null) list.Add("#");
                if (temp.left != null) queue.Enqueue(temp.left);
                if (temp.right != null) queue.Enqueue(temp.right);
            }
            return "[" + String.Join(",", list) + "]";
        }
    }
    public class ConnectSolution
    {
        //BFS using queue
        public static void ConnectQueue(TreeLinkNode root)
        {
            if (root == null) return;
            var queue = new Queue<TreeLinkNode>();
            var temp = root;
            queue.Enqueue(temp);
            while (queue.Count != 0)
            {
                temp = queue.Dequeue();
                if (temp.left != null)
                {
                    temp.left.next = temp.right;
                    queue.Enqueue(temp.left);
                    queue.Enqueue(temp.right);
                    if (temp.next != null) temp.right.next = temp.next.left;
                }
            }
        }

        //DFS recursive
        public static void ConnectRecursive(TreeLinkNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                root.left.next = root.right;
                if (root.next != null) root.right.next = root.next.left;
            }
            ConnectRecursive(root.left);
            ConnectRecursive(root.right);
        }
    }
}
