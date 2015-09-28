using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class RomanToIntSolution
    {
        public static int RomanToInt(string s)
        {
            var charArray = s.ToCharArray();
            var sum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'M')
                    sum += 1000;
                else if (charArray[i] == 'D')
                    sum += 500;
                else if (charArray[i] == 'C')
                {
                    if (i < charArray.Length - 1 && charArray[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                    }
                    else if (i < charArray.Length - 1 && charArray[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                    }
                    else sum += 100;
                }
                else if (charArray[i] == 'L')
                    sum += 50;
                else if (charArray[i] == 'X')
                {
                    if (i < charArray.Length - 1 && charArray[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                    }
                    else if (i < charArray.Length - 1 && charArray[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                    }
                    else sum += 10;
                }
                else if (charArray[i] == 'V')
                    sum += 5;
                else if (charArray[i] == 'I')
                {
                    if (i < charArray.Length - 1 && charArray[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                    }
                    else if (i < charArray.Length - 1 && charArray[i + 1] == 'V')
                    {
                        sum += 4;
                        i++;
                    }
                    else sum += 1;
                }
            }
            return sum;
        }

        public static int RomanToInt2(string s)
        {
            var specialNotation = new Dictionary<int, string>() { { 900, "CM" }, { 400, "CD" }, { 90, "XC" }, { 40, "XL" }, { 9, "IX" }, { 4, "IV" } };
            var normalNotation = new Dictionary<int, string>() { { 1, "I" }, { 5, "V" }, { 10, "X" }, { 50, "L" }, { 100, "C" }, { 500, "D" }, { 1000, "M" } };
            int sum = 0;
            int index = 0;
            foreach (var notation in specialNotation)
            {
                while ((index = s.IndexOf(notation.Value)) != -1)
                {
                    sum += notation.Key;
                    s = s.Remove(index, 2);
                }
            }
            foreach (var notation in normalNotation)
            {
                while ((index = s.IndexOf(notation.Value)) != -1)
                {
                    sum += notation.Key;
                    s = s.Remove(index, 1);
                }
            }
            return sum;
        }
    }
}
