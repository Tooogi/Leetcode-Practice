/*Write a function to find the longest common prefix string amongst an array of strings.

14. Longest Common Prefix - https://leetcode.com/problems/longest-common-prefix/description/

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:

  1 <= strs.length <= 200
  0 <= strs[i].length <= 200
  strs[i] consists of only lowercase English letters if it is non-empty.*/

/*
Thought process in steps:
1. Create a variable to store the longest common prefix
2. Loop through each character position of the first string in the array
3. Create another for loop to loop through another word in the array to compare their characters at this position
4. If the letter at the current position is different in any word, or if a word is shorter than the current position, return the variable immediately
5. If all letters are the same at this position, add the character to the variable and continue
*/

public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    string longPrefix = "";

    for (var i = 0; i < strs[0].Length; i++)
    {
      for (var k = 1; k < strs.Length; k++)
      {
        if (i >= strs[k].Length || strs[k][i] != strs[0][i])
        {
          return longPrefix;
        }

      }
      longPrefix += strs[0][i];
    }

    return longPrefix;
  }
}