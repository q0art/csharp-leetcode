using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._108.Convert_Sorted_Array_to_Binary_Search_Tree;

public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }

        return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
    }

    private TreeNode SortedArrayToBSTHelper(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        int mid = left + (right - left) / 2;
        var node = new TreeNode(nums[mid]);

        node.left = SortedArrayToBSTHelper(nums, left, mid - 1);
        node.right = SortedArrayToBSTHelper(nums, mid + 1, right);

        return node;
    }
}