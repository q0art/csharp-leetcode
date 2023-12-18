using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._257.Binary_Tree_Paths;

public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var list = new List<string>();
        
        BinaryTreePathsHelper(root, "", list);

        return list;
    }

    private void BinaryTreePathsHelper(TreeNode node, string s, List<string> list)
    {
        if (node.left == null && node.right == null)
            list.Add(s + node.val);

        if (node.left != null)
            BinaryTreePathsHelper(node.left, s + node.val + "->", list);

        if (node.right != null)
            BinaryTreePathsHelper(node.right, s + node.val + "->", list);
    }
}