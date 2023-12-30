using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._563.Binary_Tree_Tilt;

public class Solution
{
    private int result = 0;

    public int FindTilt(TreeNode root)
    {
        FindTiltHelper(root);

        return result;
    }

    private int FindTiltHelper(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = FindTiltHelper(node.left),
            right = FindTiltHelper(node.right);

        result += Math.Abs(left - right);

        return left + right + node.val;
    }
}