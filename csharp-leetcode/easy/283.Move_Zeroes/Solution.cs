namespace csharp_leetcode.easy._283.Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                continue;
            }

            nums[j] = nums[i];

            if (j != i)
            {
                nums[i] = 0;
            }

            j++;
        }
    }
}