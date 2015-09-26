using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class SingleNumberIISolution
    {
        public static int SingleNumber(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num)) dic[num]++;
                else dic.Add(num, 1);
            }
            foreach (KeyValuePair<int, int> entry in dic)
            {
                if (entry.Value == 1) return entry.Key;
            }
            return 0;
        }
    }
}
