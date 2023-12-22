namespace csharp_leetcode.easy._387.First_Unique_Character_in_a_String;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        
        foreach (char i in s)
            if (dict.ContainsKey(i))
                dict[i]++;
            else
                dict[i] = 1;

        for (int i = 0; i < s.Length; i++)
            if (dict[s[i]] == 1)
                return i;
        
        return -1;
    }
}