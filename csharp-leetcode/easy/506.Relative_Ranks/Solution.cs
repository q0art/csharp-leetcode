namespace csharp_leetcode.easy._506.Relative_Ranks;

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var dict = new Dictionary<int, int>();
        var array = new string[score.Length];

        for (int i = 0; i < score.Length; i++)
            dict[score[i]] = i;
        
        Array.Sort(score, (a, b) => b - a);

        for (int i = 0; i < score.Length; i++)
            if (i == 0)
                array[dict[score[i]]] = "Gold Medal";
            else if (i == 1)
                array[dict[score[i]]] = "Silver Medal";
            else if (i == 2)
                array[dict[score[i]]] = "Bronze Medal";
            else
                array[dict[score[i]]] = (i + 1).ToString();

        return array;
    }
}