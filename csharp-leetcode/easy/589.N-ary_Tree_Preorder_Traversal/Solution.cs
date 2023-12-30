using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._589.N_ary_Tree_Preorder_Traversal;

public class Solution
{
    private List<int> _list = new();
    
    public IList<int> Preorder(Node root)
    {
        if (root == null)
            return _list;
        
        _list.Add(root.val);

        foreach (var child in root.children)
            Preorder(child);

        return _list;
    } 
}