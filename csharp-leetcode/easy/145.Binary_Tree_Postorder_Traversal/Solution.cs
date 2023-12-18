using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._145.Binary_Tree_Postorder_Traversal;

public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        
        PostorderTraversalHelper(root, list);
        
        return list;
    }

    private void PostorderTraversalHelper(TreeNode node, List<int> list)
    {
        if (node == null)
            return;
        
        PostorderTraversalHelper(node.left, list);
        PostorderTraversalHelper(node.right, list);
        
        list.Add(node.val);
    }
}