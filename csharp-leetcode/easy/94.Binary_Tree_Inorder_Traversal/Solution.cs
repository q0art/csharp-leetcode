namespace csharp_leetcode.easy._94.Binary_Tree_Inorder_Traversal;

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
    {
            this.val = val;
            this.left = left;
            this.right = right;
    }
}

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