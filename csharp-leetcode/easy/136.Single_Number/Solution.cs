namespace csharp_leetcode.easy._136.Single_Number;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
            if (i == nums.Length - 1)
                return nums[i];

            else if (nums[i] != nums[i + 1])
                return nums[i];

        return 0;
    }
}