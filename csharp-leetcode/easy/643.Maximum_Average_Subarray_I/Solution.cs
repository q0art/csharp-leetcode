namespace csharp_leetcode.easy._643.Maximum_Average_Subarray_I;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (var i = 0; i < k; i++)
            sum += nums[i];

        var result = sum / k;

        for (var i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            result = Math.Max(result, sum / k);
        }

        return result;
    }
}