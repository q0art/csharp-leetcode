namespace csharp_leetcode.easy._461.Hamming_Distance;

public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int xor = x ^ y, result = 0;

        while (xor > 0)
        {
            result += xor & 1;
            xor >>= 1;
        }

        return result;
    }
}