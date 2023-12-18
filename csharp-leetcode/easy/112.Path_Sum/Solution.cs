using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._112.Path_Sum;

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if (root == null)
            return false;

        if (root.left == null && root.right == null && root.val - targetSum == 0)
            return true;
        
        return HasPathSum(root.left,  targetSum - root.val) 
            || HasPathSum(root.right, targetSum - root.val);
    }
}