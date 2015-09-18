using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Write a function that takes an unsigned integer 
//and returns the number of ’1' bits it has (also 
//known as the Hamming weight).
//For example, the 32-bit integer ’11' has binary 
//representation 00000000000000000000000000001011, 
//so the function should return 3.

namespace LeetCodeInCSharp
{
    public class HammingWeightSolution
    {
        public static int HammingWeight(uint n) {
            int result = 0;
            while (n > 0)
            {
                result += (int)(n % 2);
                n = n >> 1;
            }
            return result;
        }
    }
}
