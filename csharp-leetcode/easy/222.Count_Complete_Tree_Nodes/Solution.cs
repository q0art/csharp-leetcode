using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._222.Count_Complete_Tree_Nodes;

public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}