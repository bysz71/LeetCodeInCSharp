using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class IntToRomanSolution
    {
        //my way
        public static string IntToRoman(int num)
        {
            var dic1 = new Dictionary<int, string> { { 1, "I" }, { 2, "II" }, { 3, "III" }, { 4, "IV" }, { 5, "V" }, { 6, "VI" }, { 7, "VII" }, { 8, "VIII" }, { 9, "IX" }, { 0, "" } };
            var dic10 = new Dictionary<int, string> { { 1, "X" }, { 2, "XX" }, { 3, "XXX" }, { 4, "XL" }, { 5, "L" }, { 6, "LX" }, { 7, "LXX" }, { 8, "LXXX" }, { 9, "XC" }, { 0, "" } };
            var dic100 = new Dictionary<int, string> { { 1, "C" }, { 2, "CC" }, { 3, "CCC" }, { 4, "CD" }, { 5, "D" }, { 6, "DC" }, { 7, "DCC" }, { 8, "DCCC" }, { 9, "CM" }, { 0, "" } };
            var dic1000 = new Dictionary<int, string> { { 1, "M" }, { 2, "MM" }, { 3, "MMM" }, { 0, "" } };

            return dic1000[num / 1000 % 10] + dic100[num / 100 % 10] + dic10[num / 10 % 10] + dic1[num % 10];
        }

        //the smart way
        public static string IntToRoman2(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string roman = "";
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    roman += strs[i];
                }
            }
            return roman;
        }
    }
}
