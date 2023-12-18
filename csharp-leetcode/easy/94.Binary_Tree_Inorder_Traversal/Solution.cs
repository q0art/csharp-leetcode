using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._94.Binary_Tree_Inorder_Traversal;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        
        InorderTraversalHelper(root, list);

        return list;
    }

    private void InorderTraversalHelper(TreeNode node, List<int> list)
    {
        if (node != null)
        {
            InorderTraversalHelper(node.left, list);
            list.Add(node.val);
            InorderTraversalHelper(node.right, list);
        }
    }
}