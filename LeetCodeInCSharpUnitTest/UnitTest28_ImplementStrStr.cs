using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class UnitTest28_ImplementStrStr
    {
        [TestMethod]
        public void TestMethodStrStrNaive()
        {
            string haystack = "This is an interesting problem.";
            string needle1 = "";
            string needle2 = " int";
            string needle3 = "probleem";

            Assert.AreEqual(0, ImplementStrStr.StrStrNaive(haystack, needle1));
            Assert.AreEqual(10, ImplementStrStr.StrStrNaive(haystack, needle2));
            Assert.AreEqual(-1, ImplementStrStr.StrStrNaive(haystack, needle3));
        }

        [TestMethod]
        public void TestMethodHash()
        {
            string txt0 = "abc";
            string txt1 = "";

            var hash0 = ImplementStrStr.Hash(txt0);
            var hash1 = ImplementStrStr.Hash(txt1);

            Assert.AreEqual(999494, hash0);
            Assert.AreEqual(0, hash1);
        }

        [TestMethod]
        public void TestMethodRollingHash()
        {
            int oldHash = 999494;
            string oldString = "abc";
            string newString = "bcd";
            Assert.AreEqual(ImplementStrStr.Hash(newString), ImplementStrStr.RollingHash(oldHash, oldString, newString));
        }

        [TestMethod]
        public void TestMethodStrStrRabinKarp()
        {
            string haystack = "abc def";
            string needle = "abc";
            Assert.AreEqual(0, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            haystack = "abcdef";
            needle = "cd";
            Assert.AreEqual(2, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            haystack = "abcd";
            needle = "";
            Assert.AreEqual(0, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            haystack = "ab";
            needle = "abc";
            Assert.AreEqual(-1, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            haystack = "abcd efg";
            needle = "hij";
            Assert.AreEqual(-1, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            //leetcode test case 65/72 I did not pass in the first time
            haystack = "aaaabaaabbabbaaaaaabbabbbaaabababaaaaabbbbbbbbbbbbbbbaabbbbabbaababbbababababaaaabbbbaaabababbbaaabbaabbabbbbbababbabbaabbbabaabaaaaabbbaaaaaabaaaabababababbaabaabbaaaaaaaababbabaa";
            needle = "aabbaaaabbbbaabaaabaabbaaababbabbbbbaba";
            //Assert.AreEqual(-1, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            haystack = "baabbaaaaaaabbaaaaabbabbababaabbabbbbbabbabbbbbbabababaabbbbbaaabbbbabaababababbbaabbbbaaabbaababbbaabaabbabbaaaabababaaabbabbababbabbaaabbbbabbbbabbabbaabbbaa";
            needle = "bbaaaababa";
            Assert.AreEqual(107, ImplementStrStr.StrStrRabinKarp(haystack, needle));

            //var token1 = haystack.Substring(107, 10);
            //Console.WriteLine(token1);
            
        }

        
    }
}
