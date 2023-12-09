namespace csharp_leetcode.easy._70.Climbing_Stairs;

public class Solution {
    public int ClimbStairs(int n)
    {
        int left = 0, rigth = 1, res = 0;

        for (int i = 0; i < n; i++)
        {
            res = left + rigth;
            left = rigth;
            rigth = res;
        }

        return res;
    }
}