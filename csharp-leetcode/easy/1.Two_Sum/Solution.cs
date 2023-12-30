namespace csharp_leetcode.easy._1.Two_Sum;

public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
                return new int[] { dict[target - nums[i]], i };
            
            dict[nums[i]] = i;
        }

        return new int[0];
    }
}
