namespace csharp_leetcode.easy._674.Longest_Continuous_Increasing_Subsequence;

public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int result = 0;

        for (int i = 0, j = 0; j < nums.Length; j++)
        {
            if (j > 0 && nums[j - 1] >= nums[j])
                i = j;

            result = Math.Max(result, j - i + 1);
        }

        return result;
    }
}