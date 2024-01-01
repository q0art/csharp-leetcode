namespace csharp_leetcode.easy._645.Set_Mismatch;

public class Solution 
{
    public int[] FindErrorNums(int[] nums) 
    {
        int result = 0;

        foreach (int num in nums)
        {
            int index = Math.Abs(num);
            
            if (nums[index - 1] < 0)
                result = index;
            else
                nums[index - 1] *= -1;
        }

        for (int i = 0; i < nums.Length; i++) 
            if (nums[i] > 0)
                return new int[] { result, i + 1 };

        return new int[] {};
    }
}