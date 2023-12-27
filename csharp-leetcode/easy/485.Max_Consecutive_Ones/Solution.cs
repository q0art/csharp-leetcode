namespace csharp_leetcode.easy._485.Max_Consecutive_Ones;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0, i = 0;

        foreach (int num in nums)
        {
            if (num == 0)
                i = 0;
            else
                result = Math.Max(result, ++i);
        }

        return result;
    }
}