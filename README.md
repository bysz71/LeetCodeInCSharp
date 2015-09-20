# LeetCodeInCSharp

# List
+ #28 Implement strStr()
+ #66 Plus One
+ #100 Same tree
+ #104 Maximum depth of a binary tree
+ #107 Level order binary tree traversal II
+ #122 Best Time to Buy and Sell Stock II
+ #136 Single number
+ #191 Number of 1 bits
+ #226 Invert binary tree
+ #235 Lowest Common Ancestor of a Binary Search Tree
+ #237 Delete node in a linked list
+ #258 Add digits

# Detail
## #28 Implement strStr()
**Problem description**: 
Returns the index of the first occurrence of needle 
in haystack, or -1 if needle is not part of haystack.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/28_ImplementStrStr.cs)  
**Naive search runtime**: 136ms  
**Rabin-Karp runtime**: 132ms  
**Explanation**:  
There are multi-ways to solve this problem.  
- Naive string search:  
Iterate through the ```haystack``` char by char, if the char matches the first char in ```needle```, iterate through the following chars in the ```haystack``` with the length of ```needle``` to check match. This brute force search has time complexity of O(MN).  
- Rabin-karp algorithm:  
(To be solved!!)Solution passed LeetCode test, but still confusing about the 'base' choice. Has asked on StackOverFlow.  
[[StackOverFlowLink]](http://stackoverflow.com/questions/32576677/issue-with-implementing-rabin-karp-algorithm-to-search-string-in-leetcode-28-im)  
- KMP algorithm:  
(fork if you can implement)
- Boyer- Moore algorithm:  
(fork if you can implement)  

## #66 Plus One
**Problem description**: 
Given a non-negative number represented as an array of digits, plus one to the number. 
The digits are stored such that the most significant digit is at the head of the list.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/66_PlusOne.cs)  
**Rruntime**: 500ms  
**Explanation**:  
- Simple iteration solution  
Iterate through digits, from digits[length - 1] to digits[0]. If current number is not 9, the loop is not worth continueing, 
thus just add 1 to it and break the loop, return digits; otherwise make current number 0 and continue. If nothing's returned 
till now, means all digits are '9', thus create a new int array with length(digits_length + 1), and set newDigits[0] to 1;  


## #100 Same tree
**Problem description**: 
Given two binary trees, write a function to check if they are equal or not. 
Two binary trees are considered equal if they are structurally identical and the nodes have the same value.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/100_SameTree.cs)  
**Rruntime**: 160ms  
**Explanation**:  
- Recursive way:  
A very straightforward one line recursive solution. 3 cases:  
both null -> true;  
one is null but the other is not -> false;  
both not null but value not equal -> false;  
else -> check children;  

## #104 Maximum depth of a binary tree
**Problem description**: 
Given a binary tree, find its maximum depth.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/104_MaximumDepthOfABinaryTree.cs)  
**Recursive runtime**: 164ms  
**Explanation**:  
- Recursive way:  
A very straightforward one line recursive solution.

## #107 Level order binary tree traversal II  
**Problem description**: 
Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).  
**Difficulty**: 
Easy  
**code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/107_LevelOrderBinaryTreeTraversalII.cs)  
**Recursive runtime**: 502ms  
**Explanation**:  
- BFS solution:  
Use a queue to do Breadth First Search. The way I did to check the level is creating a class called NodeWithHeight to wrap the TreeNode and a Height property. So every time instead of enqueueing a node into the queue, I wrap it and its height in a NodeWithHeight object, and  enqueue this object to the queue.  

## #122 Best time to buy and sell stack II
**Problem description**: 
Say you have an array for which the ith element is the price of a given stock on day i.  
Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times). However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).  
**Difficulty**: 
Medium  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/122_BestTimeToBuyAndSellStockII.cs)  
**Runtime**: 148ms  
**Explanation**:  
- Iteration way:  
The problem description is confusing. Actually what it says is to find the maximum profit per share of a stock. Just buy at low price day (compare to day + 1) and sell at (day + 1);

## #136 Single number
**Problem description**: 
Given an array of integers, every element appears 
twice except for one. Find that single one.  
**Difficulty**: 
Medium  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/136_SingleNumber.cs)  
**Runtime**: 156ms  
**Explanation**:  
- Bitwise XOR:  
This solution uses 'bitwise XOR' to quickly solve the problem, each element in the array only needs to be checked once, the time complexity is O(N).  
```^``` is the bitwise XOR in C#. For bitwise XOR: (0 XOR 0 = 0, 0 XOR 1 = 1, 1 XOR 0 = 1, 1 XOR 1 = 0). Thus the ones are not single will offset each other, only the single number will live to the end.

## #191 Number of 1 bits
**Problem description**: 
Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
For example, the 32-bit integer '11' has binary representation 00000000000000000000000000001011, so the function should return 3.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/191_NumberOf1Bits.cs)  
**Runtime**: 56ms  
**Explanation**:  
- Bitwise shift and modulo:  
do ```n % 2```, will actually return the LSB of n in binary. Add this value to the result, and shift ```n``` 1 bit to the right. Loop until ```n``` equals 0.

## #226 Invert binary tree
**Problem description**: 
Invert a binary tree.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/226_InvertBinaryTree.cs)  
**Runtime**: 160ms  
**Explanation**:  
- Recursive way:
Feel sorry for Max Howell. I might get nervous too.

## #235 Lowest Common Ancestor of a Binary Search Tree
**Problem description**: 
Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.  
**Difficulty**: Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/235_LowestCommonAncestorOfABinarySearchTree.cs)  
**Runtime**: 188ms  
**Explanation**:  
- traversal solution:  
To find the lowest common ancestor, it is actually looking for the first node that match the conditions that both (<=) than the small node and (>=) than the large node at the same time.

## #237 Delete node in a linked list
**Problem description**: 
Write a function to delete a node (except the tail) 
in a singly linked list, given only access to that node. 
Supposed the linked list is 1 -> 2 -> 3 -> 4 and you 
are given the third node with value 3, the linked list 
should become 1 -> 2 -> 4 after calling your function.  
**Difficulty**: Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/237_DeleteNodeInALinkedList.cs)  
**Runtime**: 172ms  
**Explanation**:  
- 2 line solution:  
The list pointer is not provided, thus you cannot iterate through the list, and you are not given the previous ```next``` pointer. This problem needs an alternative way to delete the node.  
```... ---> currentNodeToBeDeleted(node 0) ---> node1 ---> node2 ---> ...```  
To delete node0, copy the value of node1 to node0, change node0's ```next``` to point to node2.  
Thus node0 now holds the properties of node1, and the node actually being discarded on the memory is node1.

## #258 Add digits
**Problem description**: 
Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.  
For example:  
Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.  
**Difficulty**: 
Easy  
**Code**: [[code]](https://github.com/scottszb1987/LeetCodeInCSharp/blob/master/LeetCodeInCSharp/258_AddDigits.cs)  
**Recursive runtime**: 68ms  
**Explanation**:  
- The best solution with O(1) time complexity:  
[[Wikipedia reference]](https://en.wikipedia.org/wiki/Digital_root)  
In short words, "If a number produces a digital root of exactly 9, then the number is a multiple of 9."  
```result = num - root((num - 1) / 9) * 9;```  
- Recursive way:  
Return the num if num < 10, else just calculate the sum and pass as parameter to itself.  
Notice that you do not have to convert ```num``` to string, there is a simpler way: [[reference]](http://stackoverflow.com/questions/478968/sum-of-digits-in-c-sharp)  
```sum = 0;
while (n != 0) {
    sum += n % 10;
    n /= 10;
}```
