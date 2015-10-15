using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class ClimbStairsSolution
    {
        public static int ClimbStairs(int n)
        {
            return Climb(n);
        }

        public static int Climb(int count)
        {
            if (count <= 0) return 1;
            if (count == 1) return 1;
            int a = Climb(count - 2);
            int b = Climb(count - 1);
            return a + b;
        }

        public static int ClimbStairsNoRecursive(int n)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            for (int i = 2; i < n; i++)
            {
                list.Add(list[i - 2] + list[i - 1]);
            }
            return list[n - 1];
        }
    }
}
