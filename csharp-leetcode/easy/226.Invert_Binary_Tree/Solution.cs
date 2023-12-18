using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._226.Invert_Binary_Tree;

public class Solution
{
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return null;

        var current = root.left;
        
        root.left = root.right;
        root.right = current;
        root.left = InvertTree(root.left);
        root.right = InvertTree(root.right);

        return root;
    }
}