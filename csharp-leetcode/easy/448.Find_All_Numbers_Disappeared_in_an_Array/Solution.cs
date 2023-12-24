namespace csharp_leetcode.easy._448.Find_All_Numbers_Disappeared_in_an_Array;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var list = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int j = Math.Abs(nums[i]) - 1;

            if (nums[j] > 0)
                nums[j] *= -1;
        }
            
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                list.Add(i + 1);

        return list;
    }
}