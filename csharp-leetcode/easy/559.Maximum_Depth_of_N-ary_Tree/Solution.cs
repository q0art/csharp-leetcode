using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._559.Maximum_Depth_of_N_ary_Tree;

public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null)
            return 0;

        int result = 0;

        foreach (Node child in root.children)
            result = Math.Max(result, MaxDepth(child));

        return result + 1;
    }
}