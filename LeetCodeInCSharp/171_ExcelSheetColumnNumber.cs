using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class TitleToNumberSolution
    {
        public static int TitleToNumber(string s)
        {
            char[] array = s.ToCharArray();
            int sum = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sum += ((int)(Convert.ToByte(array[i])) - 64) * (int)(Math.Pow(26, array.Length - 1 - i));
            }
            return sum;
        }
    }
}
