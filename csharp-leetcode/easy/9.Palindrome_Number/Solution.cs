namespace csharp_leetcode.easy._9.Palindrome_Number;

public class Solution {
    public bool IsPalindrome(int x) => x
        .ToString()
        .Zip(x.ToString().Reverse(), 
            (c, reversedChar) => c == reversedChar)
        .All(_ => _);
}