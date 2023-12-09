using System.Text;

namespace csharp_leetcode.easy._67.Add_Binary;

public class Solution {
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1, j = b.Length - 1, k = 0;
        var sb = new StringBuilder();

        while (i >= 0 || j >= 0 || k > 0)
        {
            int sum = k;

            if (i >= 0)
            {
                sum += a[i--] - '0';
            }

            if (j >= 0)
            {
                sum += b[j--] - '0';
            }

            sb.Insert(0, sum % 2);
            k = sum / 2;
        }

        return sb.ToString();
    }
}