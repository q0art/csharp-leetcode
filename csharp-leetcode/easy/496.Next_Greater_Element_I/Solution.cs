namespace csharp_leetcode.easy._496.Next_Greater_Element_I;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();
        var stack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && num > stack.Peek())
                dict[stack.Pop()] = num;

            stack.Push(num);
        }

        var list = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
            list[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;

        return list;
    }
}