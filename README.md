# LeetCodeInCSharp

# List
+ #136 Single number
+ #237 Delete node in a linked list
+ #28 Implement strStr()

# Detail
## #136 Single number
**Problem description**: 
Given an array of integers, every element appears 
twice except for one. Find that single one.  
**Difficulty**: 
Medium  
**Runtime**: 
156ms  
**Code**: 
```c#
public class SingleNumberClass
{
    public static int SingleNumber(int[] nums)
    {
        var answer = nums[0];
        for (int i = 1; i < nums.Length; i++)
            answer ^= nums[i];
        return answer;
    }
}
```
**Explaination**:  
This solution uses 'bitwise XOR' to quickly solve the problem, each element in the array only needs to be checked once, the time complexity is O(N).  
```^``` is the bitwise XOR in C#. For bitwise XOR: (0 XOR 0 = 0, 0 XOR 1 = 1, 1 XOR 0 = 1, 1 XOR 1 = 0). Thus the ones are not single will offset each other, only the single number will live to the end.

## #237 Delete node in a linked list
**Problem description**: 
Write a function to delete a node (except the tail) 
in a singly linked list, given only access to that node. 
Supposed the linked list is 1 -> 2 -> 3 -> 4 and you 
are given the third node with value 3, the linked list 
should become 1 -> 2 -> 4 after calling your function.  
**Difficulty**: 
Easy  
**Runtime**: 
172ms  
**Code**: 
```c#
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
```  
**Explaination**:  
The list pointer is not provided, thus you cannot iterate through the list, and you are not given the previous ```next``` pointer. This problem needs an alternative way to delete the node.  
```
... ---> currentNodeToBeDeleted(node 0) ---> node1 ---> node2 ---> ...
```  
Please refer to the structure above. Node 0 is the node we are given and to be deleted, node1 is its next node, node2 is node1's next node.
To delete node0, copy the value of node1 to node0, change node0's ```next``` to point to node2.  
Thus node0 now holds the properties of node1, and the node actually being discarded on the memory is node1.

## 228 Implement strStr()
**Problem description**: 
Returns the index of the first occurrence of needle 
in haystack, or -1 if needle is not part of haystack.
**Difficulty**: 
Easy  
**Runtime**: 
132ms  
**Code**:  
