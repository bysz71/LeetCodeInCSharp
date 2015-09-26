using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class SearchInsertSolution
    {
        //linear search 168ms
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                if (target <= nums[i]) return i;
            return nums.Length;
        }

        //binary search 156ms
        public static int SearchInsertBinary(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = high / 2;
            while (high != low)
            {
                if (target == nums[mid]) return mid;
                else if (target < nums[mid])
                {
                    high = mid;
                    mid = (high - low) / 2 + low;
                }
                else
                {
                    low = mid + 1;
                    mid = (high - low) / 2 + low;
                }
            }
            return target > nums[high] ? high + 1 : high;
        }
    }
}
