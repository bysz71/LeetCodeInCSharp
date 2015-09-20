using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class HasCycleSolution
    {
        public static bool HasCycle(ListNode head)
        {
            var pre = head;
            var cur = head;
            while (cur != null && cur.next != null)
            {
                if (cur.next == head) return true;
                cur = cur.next;
                pre.next = head;
                pre = cur;
            }
            return false;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
