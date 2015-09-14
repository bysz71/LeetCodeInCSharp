using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem description:
//Write a function to delete a node (except the tail) 
//in a singly linked list, given only access to that node.
//Supposed the linked list is 1 -> 2 -> 3 -> 4 and you 
//are given the third node with value 3, the linked list 
//should become 1 -> 2 -> 4 after calling your function.

namespace LeetCodeSolutions
{
    //Definition for singly-linked list.
    public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
    }

    public class DeleteNodeInALinkedList
    {
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
