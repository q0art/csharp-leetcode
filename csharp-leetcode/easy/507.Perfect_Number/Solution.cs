namespace csharp_leetcode.easy._507.Perfect_Number;

public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        int result = 1;

        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0)
                result += num / i + i;

        return num == result && num != 1;
    }
}