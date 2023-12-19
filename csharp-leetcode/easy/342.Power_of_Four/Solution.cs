namespace csharp_leetcode.easy._342.Power_of_Four;

public class Solution
{
    public bool IsPowerOfFour(int n) => Math.Log(n, 4) % 1 == 0;
}