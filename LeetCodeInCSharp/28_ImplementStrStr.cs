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
            if (haystack.Length < needle.Length) return -1;
            if (needle == "") return 0;

            var hashOfNeedle = Hash(needle);
            string oldString = haystack.Substring(0, needle.Length);
            int oldHash = Hash(oldString);
            int newHash = 0;

            if (hashOfNeedle == oldHash) return 0;

            for (int i = 1; i < haystack.Length - needle.Length + 1; i++)
            {
                newHash = RollingHash(oldHash, oldString, haystack.Substring(i, needle.Length));
                if (i == 107)
                {
                    Console.WriteLine("hash at 107:" + newHash);
                    Console.WriteLine("newString:" + haystack.Substring(i, needle.Length));
                    Console.WriteLine("needle hash:" + hashOfNeedle);
                    //Console.WriteLine(newHash + hashOfNeedle);
                }
                if (hashOfNeedle == newHash)
                    return i;
                else
                {
                    oldHash = newHash;
                    oldString = haystack.Substring(i, needle.Length);
                }
            }
            return -1;
        }

        public static int Hash(string txt)
        {
            int hash = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(txt);
            for (int i = 0; i < asciiBytes.Length; i++)
                hash += (int)(asciiBytes[i] * Math.Pow(101, asciiBytes.Length - 1 - i));
            return hash;
        }

        public static int RollingHash(int oldHash, string oldString, string newString)
        {
            int asciiHeadOfOldString = Encoding.ASCII.GetBytes(oldString.Substring(0, 1))[0];
            int asciiTailOfNewString = Encoding.ASCII.GetBytes(newString.Substring(newString.Length - 1, 1))[0];
            int newHash = (int)(oldHash - (int)(asciiHeadOfOldString * Math.Pow(101, oldString.Length - 1))) * 101 + asciiTailOfNewString;
            return newHash;
        }
    }
}
