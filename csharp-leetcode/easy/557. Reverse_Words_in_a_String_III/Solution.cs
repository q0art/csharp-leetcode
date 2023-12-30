namespace csharp_leetcode.easy._557._Reverse_Words_in_a_String_III;

public class Solution
{
    public string ReverseWords(string s) =>
        String.Join(' ', s.Split(' ').Select(w => new string(w.Reverse().ToArray())));
}