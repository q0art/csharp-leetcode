namespace csharp_leetcode.easy._268.Missing_Number;

public class Solution
{
    public int MissingNumber(int[] nums) => nums.Length * (nums.Length + 1) / 2 - nums.Sum();
}