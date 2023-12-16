namespace csharp_leetcode.easy._202.Happy_Number;

public class Solution
{
    public bool IsHappy(int n)
    {
        var hashSet = new HashSet<int>();

        while (n != 1 && !hashSet.Contains(n))
        {
            hashSet.Add(n);
            n = IsHappyHelper(n);
        }

        return n == 1;
    }

    private int IsHappyHelper(int n)
    {
        int result = 0;

        while (n > 0)
        {
            result += (n % 10) * (n % 10);
            n /= 10;
        }

        return result;
    }
}