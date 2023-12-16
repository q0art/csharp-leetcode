namespace csharp_leetcode.easy._191.Number_of_1_Bits;

public class Solution
{
    public int HammingWeight(uint n)
    {
        uint result = 0;

        while (n != 0)
        {
            result += (n % 2);
            n >>= 1;
        }

        return (int)result;
    }
}