using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._100.Same_Tree;

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q) 
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

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    } 
}