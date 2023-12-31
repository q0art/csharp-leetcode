using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._110.Balanced_Binary_Tree;

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return IsBalancedHelper(root) != -1;
    }
    
    private int IsBalancedHelper(TreeNode node) {
        if (node == null)
            return 0;

        int leftHeight = IsBalancedHelper(node.left), rightHeight = IsBalancedHelper(node.right);

        if (leftHeight == -1 || rightHeight == -1)
            return -1;

        int diffHeight = Math.Abs(leftHeight - rightHeight);

        if (diffHeight > 1)
            return -1;

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}