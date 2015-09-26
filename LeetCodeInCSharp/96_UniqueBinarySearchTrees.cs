using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class UniqueBinarySearchTreesSolution
    {
        public static int NumTrees(int n)
        {
            int[] c = new int[n + 1];
            c[0] = 1;
            for (int i = 1; i <= n; i++)
                for (int j = 0; j < i; j++)
                    c[i] += c[j] * c[i - j - 1];
            return c[n];
        }
    }
}
