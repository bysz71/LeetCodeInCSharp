using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class MajorityElementSolution
    {
        //O(nlogn)
        public static int MajoirityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }

        //O(n)
        public static int MajoirityElement2(int[] nums)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    max = nums[i];
                    count++;
                }
                else if(max == nums[i]) count++;
                else count--;
            }
            return max;
        }
    }
}
