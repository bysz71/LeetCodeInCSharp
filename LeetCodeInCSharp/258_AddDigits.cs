using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem descriptiton:
//Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
//For example:
//Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

namespace LeetCodeInCSharp
{
    public class AddDigitsSolution
    {
        public static int AddDigits(int num)
        {
            return num - (int)((num - 1) / 9) * 9;
        }
    }
}
