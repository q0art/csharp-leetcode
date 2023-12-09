namespace csharp_leetcode.easy._69.Sqrt_x_;

public class Solution 
{
    public int MySqrt(int x)
    {
        if (x == 1)
        {
            return 1;
        }

        double res = x / 2;

        while (res * res - x > 0.5)
        {
            res = (res + x / res) / 2;
        }

        return (int)res;
    }
}