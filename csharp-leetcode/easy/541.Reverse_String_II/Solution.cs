namespace csharp_leetcode.easy._541.Reverse_String_II;

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        var array = s.ToCharArray();

        for (int i = 0; i < s.Length; i += 2 * k)
            Array.Reverse(array, i, Math.Min(s.Length - i, k));

        return new string(array);
    }
}