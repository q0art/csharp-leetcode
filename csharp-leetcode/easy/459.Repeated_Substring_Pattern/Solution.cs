using System.Text;

namespace csharp_leetcode.easy._459.Repeated_Substring_Pattern;

public class Solution
{
    public bool RepeatedSubstringPattern(string s) 
    {
        for (int i = 1; i <= s.Length / 2; i++)
        {
            if (s.Length % i == 0)
            {
                var substring = s.Substring(0, i);
                var result = new StringBuilder();

                for (int j = 0; j < s.Length / i; j++)
                    result.Append(substring);

                if (s == result.ToString())
                    return true;
            }
        }

        return false;
    }
}