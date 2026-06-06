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