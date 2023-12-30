using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._543.Diameter_of_Binary_Tree;

public class Solution
{
    private int result = 0;
    
    public int DiameterOfBinaryTree(TreeNode root)
    {
        DiameterOfBinaryTreeHelper(root);
        
        return result;
    }

    private int DiameterOfBinaryTreeHelper(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = DiameterOfBinaryTreeHelper(node.left),
            right = DiameterOfBinaryTreeHelper(node.right);
        result = Math.Max(result, left + right);

        return Math.Max(left, right) + 1;
    }
}