namespace csharp_leetcode.easy._680.Valid_Palindrome_II;

public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return ValidPalindromeHelper(s, left + 1, right) ||
                       ValidPalindromeHelper(s, left, right - 1);

            left++;
            right--;
        }

        return true;
    }

    private bool ValidPalindromeHelper(string s, int left, int right)
    {
        while (left < right)
            if (s[left++] != s[right--])
                return false;

        return true;
    }
}