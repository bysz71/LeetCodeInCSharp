using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class RomanToIntSolution
    {
        //O(n) solution
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
    }
}
