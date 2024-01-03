namespace csharp_leetcode.easy._645.Set_Mismatch;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var result = 0;

        foreach (var num in nums)
        {
            var index = Math.Abs(num);

            if (nums[index - 1] < 0)
                result = index;
            else
                nums[index - 1] *= -1;
        }

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                return new[] { result, i + 1 };

        return new int[] { };
    }
}