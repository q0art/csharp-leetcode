namespace csharp_leetcode.easy._367.Valid_Perfect_Square;

public class Solution
{
    public bool IsPerfectSquare(int num) => Math.Sqrt(num) % 1 == 0;
}