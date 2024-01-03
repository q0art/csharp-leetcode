using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._637.Average_of_Levels_in_Binary_Tree;

public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var list = new List<double>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            long count = 0;
            var n = queue.Count;

            for (var i = 0; i < n; i++)
            {
                var node = queue.Dequeue();
                count += node.val;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            list.Add((double)count / n);
        }

        return list;
    }
}