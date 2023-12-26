namespace csharp_leetcode.easy._476.Number_Complement;

public class Solution
{
    public int FindComplement(int num)
    {
        int result = 1;

        while (result < num)
            result = (result << 1) + 1;

        return result ^ num;
    }
}