using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._501.Find_Mode_in_Binary_Search_Tree;

public class Solution
{
    private int currentValue = 0;
    private int currentCount = 0;
    private int maxCount = 0;
    private List<int> list = new List<int>();
    
    public int[] FindMode(TreeNode root)
    {
        FindModeHelper(root);
        
        return list.ToArray();
    }

    private void FindModeHelper(TreeNode node)
    {
        if (node == null)
            return;
        
        FindModeHelper(node.left);

        currentCount = (currentValue == node.val) ? currentCount + 1 : 1;
        currentValue = node.val;
        
        if (currentCount == maxCount)
            list.Add(currentValue);

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            
            list.Clear();
            list.Add(currentValue);
        }
            
        FindModeHelper(node.right);
    }
}