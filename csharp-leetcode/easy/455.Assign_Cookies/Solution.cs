namespace csharp_leetcode.easy._455.Assign_Cookies;

public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        int result = 0;
        
        Array.Sort(g);
        Array.Sort(s);

        for (int i = 0; i < s.Length; i++)
        {
            if (g[result] <= s[i])
                result++;
            
            if (result == g.Length)
                break;   
        }

        return result;
    }
}