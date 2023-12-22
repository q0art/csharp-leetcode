namespace csharp_leetcode.easy._392.Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;
        
        int index = 0;
        
        foreach (char i in t)
            if (s[index] == i && s.Length == ++index)
                return true;

        return false;
    }
}