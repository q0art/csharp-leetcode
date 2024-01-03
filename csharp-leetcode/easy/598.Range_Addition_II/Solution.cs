namespace csharp_leetcode.easy._598.Range_Addition_II;

public class Solution
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        foreach (var num in ops)
        {
            m = Math.Min(m, num[0]);
            n = Math.Min(n, num[1]);
        }

        return m * n;
    }
}