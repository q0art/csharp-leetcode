namespace csharp_leetcode.easy._13.Roman_to_Integer;

public class Solution {
    public int RomanToInt(string s)
    {
        int result = 0;
        var dict = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && dict[s[i]] < dict[s[i + 1]])
            {
                result -= dict[s[i]];
            }
            else
            {
                result += dict[s[i]];
            }
        }

        return result;
    }
}