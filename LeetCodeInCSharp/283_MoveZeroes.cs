using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class MoveZeroesSolution
    {
        public static void MoveZeroes(int[] nums)
        {
            int toBeSwapped = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    Swap(ref nums[i], ref nums[toBeSwapped++]);
        }
        public static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
