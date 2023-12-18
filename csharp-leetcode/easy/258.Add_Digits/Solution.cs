namespace csharp_leetcode.easy._258.Add_Digits;

public class Solution
{
    public int AddDigits(int num) => 1 + (num - 1) % 9;
}