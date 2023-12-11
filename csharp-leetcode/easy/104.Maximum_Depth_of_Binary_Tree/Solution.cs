using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._104.Maximum_Depth_of_Binary_Tree;

public class Solution
{
    public int MaxDepth(TreeNode root) 
    {
        if (root == null)
        {
            return 0;
        }

        int left = MaxDepth(root.left), right = MaxDepth(root.right);

        return Math.Max(left, right) + 1;
    }
}