namespace csharp_leetcode.easy._88.Merge_Sorted_Array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        nums2.CopyTo(nums1, m);
        Array.Sort(nums1);
    }
}