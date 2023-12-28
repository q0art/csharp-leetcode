namespace csharp_leetcode.easy._521.Longest_Uncommon_Subsequence_I;

public class Solution
{
    public int FindLUSlength(string a, string b) => (a == b) ? -1 : Math.Max(a.Length, b.Length);
}