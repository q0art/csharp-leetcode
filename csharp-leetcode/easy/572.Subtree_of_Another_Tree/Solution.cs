using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._572.Subtree_of_Another_Tree;

public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
            return false;

        return IsSubtreeHelper(root, subRoot) 
               || (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
    }

    private bool IsSubtreeHelper(TreeNode p, TreeNode q)
    {
        if (p == null || q == null)
            return p == q;

        return p.val == q.val 
               && IsSubtreeHelper(p.left, q.left) 
               && IsSubtreeHelper(p.right, q.right);
    }
}