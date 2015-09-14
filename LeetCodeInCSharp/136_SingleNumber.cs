using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class SingleNumberClass
    {
        public static int SingleNumber(int[] nums)
        {
            var answer = nums[0];
            for (int i = 1; i < nums.Length; i++)
                answer ^= nums[i];
            return answer;
        }
    }
}
