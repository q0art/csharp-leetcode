namespace csharp_leetcode.easy._594.Longest_Harmonious_Subsequence;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        int result = 0;

        foreach (int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        foreach (int num in dict.Keys)
            if (dict.ContainsKey(num + 1))
                result = Math.Max(result, dict[num] + dict[num + 1]);

        return result;
    }
}