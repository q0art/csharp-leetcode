namespace csharp_leetcode.easy._441.Arranging_Coins;

public class Solution
{
    public int ArrangeCoins(int n) => (int)(Math.Sqrt(8 * (long)n + 1) - 1) / 2;
}