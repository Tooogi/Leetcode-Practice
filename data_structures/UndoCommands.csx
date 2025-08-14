public class Solution
{
  public string UndoCommands(string[] commands)
  {
    Stack<string> myStack = new Stack<string>();
    Stack<string> myStack1 = new Stack<string>();
    string x = "";

    for (int i = 0; i < commands.Length; i++)
    {
      myStack.Push(commands[i]);

      if (commands[i] == "UNDO")
      {
        myStack.Pop();
      }
    }

    while (myStack.Count > 0)
    {
      myStack1.Push(myStack.Pop());
    }

    while(myStack1.Count > 0){
      x += myStack1.Pop();
    }

    return x;
  }
}

var sol = new Solution();
var result = sol.UndoCommands(new string[] { "a","b","c","UNDO","d" });
Console.WriteLine(result);