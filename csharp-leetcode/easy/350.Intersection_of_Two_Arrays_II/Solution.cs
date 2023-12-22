namespace csharp_leetcode.easy._350.Intersection_of_Two_Arrays_II;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var list = new List<int>(nums2);

        for (int i = 0; i < nums1.Length; i++)
            if (list.Contains(nums1[i]))
            {
                result.Add(nums1[i]);
                list.Remove(nums1[i]);
            }

        return result.ToArray();
    }
}