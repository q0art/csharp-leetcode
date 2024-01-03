namespace csharp_leetcode.easy._628.Maximum_Product_of_Three_Numbers;

public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        var n = nums.Length;

        Array.Sort(nums);

        return Math.Max(nums[n - 1] * nums[0] * nums[1],
            nums[n - 3] * nums[n - 2] * nums[n - 1]);
    }
}