namespace csharp_leetcode.easy._26.Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var count = 1;

        for (var i = 0; i < nums.Length; i++)
            if (nums[count - 1] != nums[i])
                nums[count++] = nums[i];

        return count;
    }
}