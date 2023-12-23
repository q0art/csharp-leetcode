using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._404.Sum_of_Left_Leaves;

public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null)
            return 0;

        int result = 0;

        if (root.left != null && root.left.left == null && root.left.right == null)
            result += root.left.val;

        result += SumOfLeftLeaves(root.left);
        result += SumOfLeftLeaves(root.right);

        return result;
    }
}