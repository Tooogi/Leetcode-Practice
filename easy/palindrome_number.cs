/*
9. Palindrome Number - https://leetcode.com/problems/palindrome-number/

Given an integer x, return true if x is a palidrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Constraints:

  -2^31 <= x <= 2^31 - 1

Follow up: Could you solve it without converting the integer to a string? */

/*
Thought process in steps:
1. Create two variables (digit, reversedNumber)
2. If x is not equal to 0, then divided x by 10 and get the remainder
3. Multiply reversedNumber by 10 and add the remainder to build the reversedNumber
*/

public class Solution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;

    int reversedNumber = 0;
    int original = x;

    while (0 < x)
    {
      int digit = x % 10;
      reversedNumber = reversedNumber * 10 + digit;
      x /= 10;
    }

    return reversedNumber == original;
  }
}