using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class SingleNumberIIISolution
    {
        public static int[] SingleNumber(int[] nums)
        {
            int aXORb = 0;
            foreach (int i in nums)
                aXORb ^= i;
            int lastSetBit = aXORb & (-aXORb);
            int[] singleNumber = new int[] { 0, 0 };
            foreach (int i in nums)
            {
                if ((i & lastSetBit) == 0) singleNumber[0] ^= i;
                else singleNumber[1] ^= i;
            }
            return singleNumber;
        }
    }
}
