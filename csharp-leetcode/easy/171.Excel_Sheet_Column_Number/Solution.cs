namespace csharp_leetcode.easy._171.Excel_Sheet_Column_Number;

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int result = 0;

        for (int i = 0; i < columnTitle.Length; i++)
            result = result * 26 + columnTitle[i] - 'A' + 1;

        return result;
    }
}