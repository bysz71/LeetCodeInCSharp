using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class NimGameSolution
    {
        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}
