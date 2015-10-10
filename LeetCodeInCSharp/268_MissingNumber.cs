using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class MissingNumberSolution
    {
        public static int MissingNumber(int[] nums)
        {
            int sum = nums.Length * (nums.Length + 1) / 2;
            foreach (var num in nums)
            {
                sum -= num;
            }
            return sum;
        }
    }
}
