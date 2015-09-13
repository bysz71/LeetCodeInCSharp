using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Implement strStr().
//Returns the index of the first occurrence of needle 
//in haystack, or -1 if needle is not part of haystack.

namespace LeetCodeSolutions
{
    public class ImplementStrStr
    {
        //The brute force search
        public static int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {   
                if (haystack[i] == needle[0])
                {
                    bool equal = true;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (needle[j] != haystack[i + j])
                        {
                            equal = false;
                            break;
                        }
                    }
                    if (equal == true) return i;
                }
            }
            return -1;
        }
    }
}
