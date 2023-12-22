namespace csharp_leetcode.easy._389.Find_the_Difference;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int result = t.Sum(s => s);

        result -= s.Sum(s => s);

        return (char)result;
    }
}