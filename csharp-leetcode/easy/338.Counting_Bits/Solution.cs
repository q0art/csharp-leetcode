namespace csharp_leetcode.easy._338.Counting_Bits;

public class Solution
{
    public int[] CountBits(int n)
    {
        var array = new int[n + 1];

        for (int i = 1; i <= n; i++)
            array[i] = array[i / 2] + (i % 2);

        return array;
    }
}