namespace csharp_leetcode.easy._495.Teemo_Attacking;

public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (duration == 0)
            return 0;

        int result = duration;

        for (int i = 0; i < timeSeries.Length - 1; i++)
            result += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);

        return result;
    }
}