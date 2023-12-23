namespace csharp_leetcode.easy._401.Binary_Watch;

public class Solution
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var list = new List<string>();

        for (int i = 0; i < 12; i++)
            for (int j = 0; j < 60; j++)
                if (ReadBinaryWatchHelper(i) + ReadBinaryWatchHelper(j) == turnedOn)
                    list.Add($"{i}:{j:D2}");
        
        return list;
    }

    private int ReadBinaryWatchHelper(int n)
    {
        int result = 0;

        while (n > 0)
        {
            result += n & 1;
            n >>= 1;
        }

        return result;
    }
}