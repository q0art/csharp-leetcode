namespace csharp_leetcode.easy._58.Length_of_Last_Word;

public class Solution 
{
    public int LengthOfLastWord(string s) => s.Trim().Split(' ').Last().Length;
}