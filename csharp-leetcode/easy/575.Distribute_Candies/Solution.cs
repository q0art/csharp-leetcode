namespace csharp_leetcode.easy._575.Distribute_Candies;

public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        return Math.Min(candyType.Length / 2, candyType.Distinct().Count());
    }
}