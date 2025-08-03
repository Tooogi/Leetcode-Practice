/*
1. Two Sum - https://leetcode.com/problems/two-sum/

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?*/


/*
Thought process in steps:
1. Create a variable
2. Loop through the nums array using a for loop
3. Subtract the current number from the target and store the result in the variable
4. Create another for loop to check if the value stored in the variable matches any of the numbers in the nums array
*/

public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    for (int i = 0; i < nums.Length; i++)
    {
      int difference = target - nums[i];

      for (int k = 0; k < nums.Length; k++)
      {
        if (k != i && nums[k] == difference)
        {
          return [i, k];
        }
      }
    }

    return [];
  }
}