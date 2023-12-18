namespace csharp_leetcode.easy._125.Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s == null || s.Length <= 1)
            return true;

        s = s.ToLower();
        
        var list = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            
            if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                list.Add(c);
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != list[list.Count - i - 1])
                return false;
        }

        return true;
    }
}