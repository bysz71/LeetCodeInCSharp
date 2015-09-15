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
        //The Naive String Match algorithm
        public static int StrStrNaive(string haystack, string needle)
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

        public static int StrStrRabinKarp(string haystack, string needle)
        {
            int len = needle.Length;
            //2 special case
            if (haystack.Length < len) return -1;
            if (needle == "") return 0;

            //base prime number used for rabin-karp's hash function
            int basement = 256;
            //prime number used to scale down the hash value
            int prime = 31;
            //the factor used to multiply with the character to be removed from the hash
            int factor = (int)((Math.Pow(basement, needle.Length - 1)) % prime);

            //get ascii value of the needle and the initial window
            int needleHash = 0;
            int windowHash = 0;
            byte[] needleBytes = Encoding.ASCII.GetBytes(needle);
            byte[] windowBytes = Encoding.ASCII.GetBytes(haystack.Substring(0, len));

            //generate hash value for both
            for (int i = 0; i < needle.Length; i++)
            {
                needleHash = (needleHash * basement + needleBytes[i]) % prime;
                windowHash = (windowHash * basement + windowBytes[i]) % prime;
            }

            //loop to find match
            bool findMatch = true;
            for (int i = 0; i < haystack.Length - len + 1; i++)
            {
                //if hash value matches, incase the hash value are not uniq, iterate through needle and window
                if (needleHash == windowHash)
                {
                    findMatch = true;
                    for (int j = 0; j < len; j++)
                    {
                        if (needle[j] != haystack[i + j])
                        {
                            findMatch = false;
                            break;
                        }
                    }
                    if (findMatch == true) return i;
                }
                //move the sliding window and find the hash value for new window
                if (i < haystack.Length - len)
                {
                    byte removeByte = Encoding.ASCII.GetBytes(haystack.Substring(i, 1))[0];
                    byte addByte = Encoding.ASCII.GetBytes(haystack.Substring(i + len, 1))[0];
                    //function of rolling hash
                    windowHash = ((windowHash - removeByte * factor) * basement + addByte) % prime;
                    //ensure the window hash to be positive
                    if (windowHash < 0) windowHash += prime;
                }
            }
            return -1;
        }
    }
}
