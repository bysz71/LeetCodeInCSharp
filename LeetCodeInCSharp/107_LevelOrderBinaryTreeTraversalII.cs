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
            if ((root == null) || (root.left == null && root.right == null)) return null;
            List<IList<int>> list = new List<IList<int>>();
            List<int> pair = new List<int>();

            if (root.left != null) pair.Add(root.left.val);
            if (root.right != null) pair.Add(root.right.val);
            
            if(LevelOrderBottom(root.left) != null)
                list.AddRange(LevelOrderBottom(root.left));
            if (LevelOrderBottom(root.right) != null)
                list.AddRange(LevelOrderBottom(root.right));
            list.Add(pair);
            //Console.WriteLine(list[0][0]);
            //Console.WriteLine(list[0][1]);
            return list;
        }
    }

    public static class extension
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
        {
            foreach (var cur in enumerable)
            {
                collection.Add(cur);
            }
        }
    }
}
