using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class ConvertToTitleSolution
    {
        public static string ConvertToTitle(int n)
        {
            string title = "";
            n--;
            while (n / 26 != 0)
            {
                title = System.Text.Encoding.ASCII.GetString(new byte[] { (byte)(n % 26 + 65) }) + title;
                n = n / 26 - 1;
            }
            title = System.Text.Encoding.ASCII.GetString(new byte[] { (byte)(n % 26 + 65) }) + title;
            return title;
        }
    }
}
