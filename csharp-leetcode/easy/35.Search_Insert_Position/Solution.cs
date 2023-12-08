namespace csharp_leetcode.easy._35.Search_Insert_Position;

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }else if (nums[i] > target)
            {
                return i;
            }
        }

        return nums.Length;
    }
}