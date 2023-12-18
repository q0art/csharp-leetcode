namespace csharp_leetcode.easy._290.Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var list = s.Split(" ");

        if (list.Length != pattern.Length)
            return false;

        var dictString = new Dictionary<string, int>();
        var dictChar = new Dictionary<char, int>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!dictString.ContainsKey(list[i]))
                dictString[list[i]] = i;

            if (!dictChar.ContainsKey(pattern[i]))
                dictChar[pattern[i]] = i;

            if (dictString[list[i]] != dictChar[pattern[i]])
                return false;
        }

        return true;
    }
}