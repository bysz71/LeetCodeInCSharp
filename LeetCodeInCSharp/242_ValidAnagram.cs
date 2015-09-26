using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class ValidAnagramSolution
    {
        public static bool IsAnagram(string s, string t)
        {
            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();
            Array.Sort(sArr);
            Array.Sort(tArr);
            var newS = new string(sArr);
            var newT = new string(tArr);
            return newS == newT;
        }

        public static bool IsAnagram2(string s, string t)
        {
            int[] alphabet = new int[26];
            foreach (var byt in Encoding.ASCII.GetBytes(s))
            {
                alphabet[byt - 97]++;
            }
            foreach (var byt in Encoding.ASCII.GetBytes(t))
            {
                alphabet[byt - 97]--;
            }
            foreach (var count in alphabet)
                if (count != 0) return false;
            return true;
        }
    }
}
