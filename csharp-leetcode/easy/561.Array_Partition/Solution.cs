namespace csharp_leetcode.easy._561.Array_Partition;

public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        int result = 0;
        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
            result += nums[i];

        return result;
    }
}