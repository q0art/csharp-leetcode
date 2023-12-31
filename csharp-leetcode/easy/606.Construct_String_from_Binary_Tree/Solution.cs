using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._606.Construct_String_from_Binary_Tree;

public class Solution
{
    public string Tree2str(TreeNode root)
    {
        if (root == null)
            return "";
        
        string left = Tree2str(root.left), 
            right = Tree2str(root.right),
            result = root.val.ToString();

        return left == "" && right == ""
            ? result
            : result + (left == "" ? "()" : $"({left})") + (right == "" ? "" : $"({right})");
    }
}