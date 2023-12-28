using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._530.Minimum_Absolute_Difference_in_BST;

public class Solution
{
    private int result = Int32.MaxValue;
    private TreeNode prev = null;
    
    public int GetMinimumDifference(TreeNode root)
    {
        if (root == null)
            return result;

        GetMinimumDifference(root.left);

        if (prev != null)
            result = Math.Min(result, root.val - prev.val);

        prev = root;
        GetMinimumDifference(root.right);

        return result;
    }
}