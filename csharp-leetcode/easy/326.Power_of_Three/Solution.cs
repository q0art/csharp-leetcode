namespace csharp_leetcode.easy._326.Power_of_Three;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
            return false;

        while (n % 3 == 0)
            n /= 3;

        return n == 1;
    }
}