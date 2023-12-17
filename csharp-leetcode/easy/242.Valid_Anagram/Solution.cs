namespace csharp_leetcode.easy._242.Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var sArray = s.ToCharArray();
        var tArray = t.ToCharArray();
        
        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }
}