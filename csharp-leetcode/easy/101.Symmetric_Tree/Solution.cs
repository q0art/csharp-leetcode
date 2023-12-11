using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._101.Symmetric_Tree;

public class Solution
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null)
        {
            return true;
        }

        return IsSymmetricHelper(root.left, root.right);
    }

    private bool IsSymmetricHelper(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        return IsSymmetricHelper(p.left, q.right) && IsSymmetricHelper(p.right, q.left);
    }
}