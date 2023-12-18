namespace csharp_leetcode.easy._190.Reverse_Bits;

public class Solution
{
    public uint reverseBits(uint n)
    {
        if (n == 0)
            return 0;

        uint result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;

            if ((n & 1) == 1)
            {
                result++;
            }

            n >>= 1;
        }

        return result;
    }
}