// 136. Single Number
/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,1]

Output: 1

Example 2:

Input: nums = [4,1,2,1,2]

Output: 4

Example 3:

Input: nums = [1]

Output: 1

 

Constraints:

1 <= nums.length <= 3 * 104
-3 * 104 <= nums[i] <= 3 * 104
Each element in the array appears twice except for one element which appears only once.
*/
// Solution :
/*
public class Solution {
    public int SingleNumber(int[] nums) {
        int count = 0;
        foreach(int num in nums){
            count ^= num;
        }
    return count;
    }
}
*/
//169. Majority Element
/*
 Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
The input is generated such that a majority element will exist in the array.
 

Follow-up: Could you solve the problem in linear time and in O(1) space?
*/
// Solution : 
/*
 public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0; int candidate = -1;
        for(int i = 0; i < nums.Length;i++){
            if ( count == 0){
                candidate = nums[i];
                count = 1;
            }else{
                if(nums[i] == candidate){
                    count++;
                }else{
                    count--;
                }
            }
        }
        count = 0;
        for(int i = 0; i< nums.Length;i++){
            if(nums[i] == candidate){
                count++;
            }
            if( count > (nums.Length / 2)){
                return candidate;
            }
        }
        return -1;
    }
}
*/
//66. Plus One
/*
 You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
 

Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's.
*/
// Solution Code: 
/*
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i] = 0;

            }

        }
        int[] newArrayPlusOne = new int[digits.Length + 1];
        newArrayPlusOne[0] = 1;
        return newArrayPlusOne;
    }
}
*/