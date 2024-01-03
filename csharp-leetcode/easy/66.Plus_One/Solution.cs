namespace csharp_leetcode.easy._66.Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;

                return digits;
            }

            digits[i] = 0;
        }

        var result = new int[digits.Length + 1];

        result[0] = 1;

        return result;
    }
}