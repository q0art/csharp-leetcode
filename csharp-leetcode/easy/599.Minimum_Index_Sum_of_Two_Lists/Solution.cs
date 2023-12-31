namespace csharp_leetcode.easy._599.Minimum_Index_Sum_of_Two_Lists;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var list = new List<string>();
        var dict = new Dictionary<string, int>();
        int minIndex = int.MaxValue;

        for (int i = 0; i < list1.Length; i++)
            dict[list1[i]] = i;
        
        for (int i = 0; i < list2.Length; i++)
            if (dict.TryGetValue(list2[i], out int index))
            {
                index += i;

                if (index < minIndex)
                {
                    minIndex = index;
                    
                    list.Clear();
                    list.Add(list2[i]);
                } else if (index == minIndex)
                    list.Add(list2[i]);
            }

        return list.ToArray();
    }
}