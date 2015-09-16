using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Given an array of integers, every element appears 
//twice except for one. Find that single one.

namespace LeetCodeInCSharp
{
    public class SingleNumberClass
    {
        public static int SingleNumber(int[] nums)
        {
            var answer = nums[0];
            //use bitwise XOR to filter out the ones in pair
            for (int i = 1; i < nums.Length; i++)
                answer ^= nums[i];
            return answer;
        }
    }
}
