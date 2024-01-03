namespace csharp_leetcode.easy._20.Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>
                   {
                       { '{', '}' },
                       { '[', ']' },
                       { '(', ')' }
                   };

        for (var i = 0; i < s.Length; i++)
            if (dict.Keys.Contains(s[i]))
                stack.Push(s[i]);
            else if (stack.Count > 0 && s[i] == dict[stack.Peek()])
                stack.Pop();
            else
                return false;

        return stack.Count == 0;
    }
}