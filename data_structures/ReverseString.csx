public class Solution {
    public string ReverseString(string s) {
        Stack<char> myStack = new Stack<char>();
        string x = "";

        for(int i = 0; i < s.Length; i++){
            myStack.Push(s[i]); 
        }

        while(myStack.Count > 0){
            var k = myStack.Pop();
            x += k;
        }
        return x;
    }
    
}

var sol = new Solution();
var result = sol.ReverseString("abcd");
Console.WriteLine(result);