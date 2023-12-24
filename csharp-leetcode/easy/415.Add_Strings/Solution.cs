using System.Text;

namespace csharp_leetcode.easy._415.Add_Strings;

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var s = new StringBuilder();
        int i = num1.Length - 1, j = num2.Length - 1, k = 0;

        while (i >= 0 || j >= 0 || k > 0)
        {
            if (i >= 0)
                k += num1[i--] - '0';

            if (j >= 0)
                k += num2[j--] - '0';

            s.Insert(0, k % 10);
            k /= 10;
        }

        return s.ToString();
    }
}