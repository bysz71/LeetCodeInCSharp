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
