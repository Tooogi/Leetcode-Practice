/*20. Valid Parentheses - https://leetcode.com/problems/valid-parentheses/description/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:
  Open brackets must be closed by the same type of brackets.
  Open brackets must be closed in the correct order.
  Every close bracket has a corresponding open bracket of the same type.

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

Example 5:

Input: s = "([)]"

Output: false

Constraints:

  1 <= s.length <= 104
  s consists of parentheses only '()[]{}'.*/

/*Thought process in steps:
I should use Stack in this solution
1. Create a Stack
2. Create a Dictionary to store opening parentheses to their corresponding closing parentheses
3. Loop through input string using for loop and check the first character
4. Store opening parentheses into the Stack
5. Check the next character in input string and match with the Dictionary that it's the closing prantheses
6. If so, check the last character in the Stack and if it's matched, then pop out from the Stack
7. Continue until the input string is fully processed
8. If Stack is empty, return true, otherwise false
*/

public class Solution {
  public bool IsValid(string s) {
    Stack<char> myStack = new Stack<char>(); 
    var myDictionary = new Dictionary<char, char> {
      { '(', ')' }, 
      { '[', ']' }, 
      { '{', '}' } 
    }; 

    for(int i = 0; i < s.Length; i++)
    { 
      char x = s[i];
      char expectedClose;
      bool isMatch = myDictionary.TryGetValue(x, out expectedClose);

      if(isMatch)
      {
        myStack.Push(x);
      }
      else 
      {
        if(myStack.Count == 0) return false;

        char top = myStack.Peek();
        if(myDictionary[top] == x) 
        {
          myStack.Pop();
        } 
        else 
        {
          return false;
        }
      }
    }

    return myStack.Count == 0;
  }
}