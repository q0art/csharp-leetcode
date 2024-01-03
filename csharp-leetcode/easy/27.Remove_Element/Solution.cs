namespace csharp_leetcode.easy._27.Remove_Element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != val)
                nums[count++] = nums[i];

        return count;
    }
}