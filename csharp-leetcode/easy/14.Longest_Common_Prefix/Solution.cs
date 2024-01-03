namespace csharp_leetcode.easy._14.Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] s)
    {
        var prefix = "";

        Array.Sort(s);

        for (var i = 0; i < s[0].Length; i++)
            if (s[0][i] != s[s.Length - 1][i])
                return prefix;
            else
                prefix += s[0][i];

        return prefix;
    }
}