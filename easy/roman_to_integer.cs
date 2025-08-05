/*
13. Roman to Integer - https://leetcode.com/problems/roman-to-integer/description/
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer.

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Constraints:

    1 <= s.length <= 15
    s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    It is guaranteed that s is a valid roman numeral in the range [1, 3999].*/

/*
Thought process in steps:
1. Create a variable
2. Loop through the Roman numerals string using a for loop
3. Use a switch statement to determine the integer value of the current Roman character
4. If the next character has a greater value, subtract the current value from the variable. Otherwise, add the current value to the variable.
5. At the end, return the variable.
*/

public class Solution
{
  public int RomanToInt(string s)
  {
    int total = 0;
    int GetValue(char c)
    {
      return c switch
      {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
      };
    }

    for (int i = 0; i < s.Length - 1; i++)
    {
      int current = GetValue(s[i]);
      int next = GetValue(s[i + 1]);

      if (current < next)
      {
        total -= current;
      }
      else
      {
        total += current;
      }
    }

    total += GetValue(s[^1]);

    return total;
  }
}