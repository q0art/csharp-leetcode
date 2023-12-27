using System.Text;

namespace csharp_leetcode.easy._482.License_Key_Formatting;

public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        var sb = new StringBuilder();
        
        for (int i = s.Length - 1; i >= 0; i--)
            if (s[i] != '-')
            {
                if (sb.Length % (k + 1) == k)
                    sb.Append('-');

                sb.Append(char.ToUpper(s[i]));
            }

        var result = sb.ToString().ToCharArray();
        Array.Reverse(result);

        return new string(result);
    }
}