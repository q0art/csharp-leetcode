using System.Text;

namespace csharp_leetcode.easy._168.Excel_Sheet_Column_Title;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();

        while (columnNumber > 0)
        {
            sb.Insert(0, (char)('A' + (columnNumber - 1) % 26));
            columnNumber = (columnNumber - 1) / 26;
        }

        return sb.ToString();
    }
}