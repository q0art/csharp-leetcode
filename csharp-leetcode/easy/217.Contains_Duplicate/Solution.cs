namespace csharp_leetcode.easy._217.Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSet.Contains(nums[i]))
                return true;

            hashSet.Add(nums[i]);
        }

        return false;
    }
}