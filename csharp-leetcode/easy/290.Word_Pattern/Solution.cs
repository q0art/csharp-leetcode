namespace csharp_leetcode.easy._290.Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var list = s.Split(" ");

        if (list.Length != pattern.Length)
        {
            return false;
        }

        var sDict = new Dictionary<string, int>();
        var cDict = new Dictionary<char, int>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!sDict.ContainsKey(list[i]))
            {
                sDict[list[i]] = i;
            }

            if (!cDict.ContainsKey(pattern[i]))
            {
                cDict[pattern[i]] = i;
            }

            if (sDict[list[i]] != cDict[pattern[i]])
            {
                return false;
            }
        }

        return true;
    }
}