namespace csharp_leetcode.easy._263.Ugly_Number;

public class Solution
{
    public bool IsUgly(int n) 
    {
        if (n == 0)
            return false;

        while (n % 2 == 0)
            n /= 2;

        while (n % 3 == 0)
            n /= 3;

        while (n % 5 == 0)
            n /= 5;

        return n == 1;
    }
}