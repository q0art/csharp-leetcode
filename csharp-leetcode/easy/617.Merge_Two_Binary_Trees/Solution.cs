using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._617.Merge_Two_Binary_Trees;

public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
            return null;

        var value = (root1?.val ?? 0) + (root2?.val ?? 0);
        var root = new TreeNode(value);

        root.left = MergeTrees(root1?.left, root2?.left);
        root.right = MergeTrees(root1?.right, root2?.right);

        return root;
    }
}