namespace csharp_leetcode.easy._26.Remove_Duplicates_from_Sorted_Array;

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int unique = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[unique - 1] != nums[i])
            {
                nums[unique] = nums[i];
                unique++;
            }
        }

        return unique;
    }
}