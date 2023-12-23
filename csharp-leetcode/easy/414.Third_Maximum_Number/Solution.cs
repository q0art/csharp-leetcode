using System.Diagnostics;

namespace csharp_leetcode.easy._414.Third_Maximum_Number;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (int num in nums)
        {
            hashSet.Add(num);

            if (hashSet.Count > 3)
                hashSet.Remove(hashSet.Min());
        }

        if (hashSet.Count < 3)
        {
            return hashSet.Max();
        }

        return hashSet.Min();
    }
}