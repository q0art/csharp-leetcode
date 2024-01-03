using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._671.Second_Minimum_Node_In_a_Binary_Tree;

public class Solution
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        if (root == null)
            return -1;

        return FindSecondMinimumValueHelper(root, root.val);
    }

    private int FindSecondMinimumValueHelper(TreeNode node, int n)
    {
        if (node == null)
            return -1;

        if (node.val > n)
            return node.val;

        int firstMinValue = FindSecondMinimumValueHelper(node.left, n),
            secondMinValue = FindSecondMinimumValueHelper(node.right, n);

        return firstMinValue == -1 || secondMinValue == -1
            ? Math.Max(firstMinValue, secondMinValue)
            : Math.Min(firstMinValue, secondMinValue);
    }
}