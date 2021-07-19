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
            if (1 <= s?.Length && s?.Length >= 15) return 0;
            if (!CheckString(s.ToUpper()) || string.IsNullOrWhiteSpace(s) ) return 0;

            var lst = s?.ToUpper().ToCharArray().Select(x => ConvertCharToNumber(x)).ToList();
            int sum = 0;
            int current = 0;
            for (int i = 0; i < lst?.Count; i++)
            {
                //current = i==0 ? lst[i]: lst[i-1];
                if (i == 0) current = lst[i]; else current = lst[i - 1];
                var IXC = new int[] { 1, 10, 100 };
                if (IXC.Any(x => x == current) && IXC.Any(x => x < lst[i]))
                    sum += lst[i] -(2 * current);
                else
                    sum += lst[i];
            }

            return sum;
        }
                private static bool CheckString( string s) => s.All(new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' }.Contains);

        private static int ConvertCharToNumber(char s) => s switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
        
    }
}
