namespace csharp_leetcode.easy._228.Summary_Ranges;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var list = new List<string>();

        if (nums == null || nums.Length == 0)
        {
            return list;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];

            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1)
            {
                i++;
            }

            int end = nums[i];
            
            list.Add(start == end ? $"{start}" : $"{start}->{end}");
        }

        return list;
    }
}