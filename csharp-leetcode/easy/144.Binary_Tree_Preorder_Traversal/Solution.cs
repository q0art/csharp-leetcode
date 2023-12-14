using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._144.Binary_Tree_Preorder_Traversal;

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        
        PreorderTraversalHelper(root, list);

        return list;
    }

    private void PreorderTraversalHelper(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }
        
        list.Add(node.val);
        
        PreorderTraversalHelper(node.left, list);
        PreorderTraversalHelper(node.right, list);
    }
}