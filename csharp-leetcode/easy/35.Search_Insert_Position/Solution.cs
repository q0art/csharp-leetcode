namespace csharp_leetcode.easy._35.Search_Insert_Position;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > target || nums[i] == target)
                return i;

        return nums.Length;
    }
}