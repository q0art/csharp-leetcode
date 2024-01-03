using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._653.Two_Sum_IV___Input_is_a_BST;

public class Solution
{
    private readonly HashSet<int> _hashSet = new();

    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
            return false;

        if (_hashSet.Contains(k - root.val))
            return true;

        _hashSet.Add(root.val);

        return FindTarget(root.left, k) ||
               FindTarget(root.right, k);
    }
}