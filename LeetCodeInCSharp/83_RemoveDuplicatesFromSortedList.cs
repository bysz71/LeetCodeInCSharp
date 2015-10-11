using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class DeleteDuplicatesSolution
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            var pointer = head;
            while (pointer.next != null)
            {
                while (pointer.val == pointer.next.val)
                {
                    pointer.next = pointer.next.next;
                    if (pointer.next == null) return head;
                }
                pointer = pointer.next;
            }
            return head;
        }
    }
}
