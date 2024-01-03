namespace csharp_leetcode.easy._9.Palindrome_Number;

public class Solution {
    public bool IsPalindrome(int x) {
        var s = x.ToString();

        return s.Zip(s.Reverse(), (c, reversedChar) => c == reversedChar).All(_ => _);
    }
}