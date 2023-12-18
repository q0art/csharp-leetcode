namespace csharp_leetcode.easy._205.Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var dict = new Dictionary<char, char>();
        var hashSet = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                if (dict[s[i]] != t[i])
                    return false;
            }
            else
            {
                if (hashSet.Contains(t[i]))
                    return false;

                dict[s[i]] = t[i];
                hashSet.Add(t[i]);
            }
        }

        return true;
    }
}