namespace csharp_leetcode.easy._231.Power_of_Two;

public class Solution
{
    public bool IsPowerOfTwo(int n) => Math.Log2(n) % 1 == 0;
}
