using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._590.N_ary_Tree_Postorder_Traversal;

public class Solution
{
    private List<int> _list = new();
    
    public IList<int> Postorder(Node root)
    {
        if (root == null)
            return _list;

        foreach (Node child in root.children)
            Postorder(child);
        
        _list.Add(root.val);

        return _list;
    }
}