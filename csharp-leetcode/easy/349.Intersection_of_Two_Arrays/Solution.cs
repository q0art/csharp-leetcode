namespace csharp_leetcode.easy._349.Intersection_of_Two_Arrays;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2) => nums1.Intersect(nums2).ToArray();
}