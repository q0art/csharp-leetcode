namespace csharp_leetcode.easy._1.Two_Sum;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        var selected = nums
            .Select((v, i) => new { Value = v, Index = i });
        
        var result = selected
            .FirstOrDefault(item => {
                if(dict.ContainsKey(target - item.Value))
                    return true;

                dict[item.Value] = item.Index;

                return false;
            }, null);

        return result is null
            ? Array.Empty<int>()
            : new int[] { dict[target - result.Value], result.Index };
    }
}