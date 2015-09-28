using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class MaxSubArraySolution
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int prev = nums[0];
            int cur = prev;
            int max = cur;

            for (int i = 1; i < nums.Length; i++ )
            {
                if (prev > 0) cur = prev + nums[i];
                else cur = nums[i];
                max = Math.Max(max, cur);
                prev = cur;
            }

            return max;
        }
    }
}
