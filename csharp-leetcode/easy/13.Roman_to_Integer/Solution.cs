namespace csharp_leetcode.easy._13.Roman_to_Integer;

public class Solution 
{
    private readonly Dictionary<char, int> dict = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s) {
        var selected = s.Select((v, i) => new { Value = dict[v], Index = i });

        var result = selected.Select(item =>
            (s.Length - 1 > item.Index && dict[s[item.Index + 1]] > item.Value)
                ? item.Value * -1
                : item.Value);

        return result.Sum();
    }
}