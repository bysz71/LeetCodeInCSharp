using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class ProductExceptSelfSolution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            int pre = 1;
            int post = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = pre;
                pre *= nums[i];
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= post;
                post *= nums[i];
            }
            return result;
        }
    }
}
