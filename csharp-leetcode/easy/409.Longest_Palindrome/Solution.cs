namespace csharp_leetcode.easy._409.Longest_Palindrome;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        var hashSet = new HashSet<char>();
        int result = 0;
        
        foreach (char i in s)
            if (hashSet.Contains(i))
            {
                hashSet.Remove(i);
                result += 2;
            }
            else
                hashSet.Add(i);

        return hashSet.Count > 0 ? result + 1 : result;
    }
}