namespace csharp_leetcode.easy._119.Pascal_s_Triangle_II;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var list = new List<int>();

        for (int i = 0; i <= rowIndex; i++)
        {
            var listRow = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    listRow.Add(1);
                }
                else
                {
                    listRow.Add(list[j - 1] + list[j]);
                }
            }

            list = listRow;
        }

        return list;
    }
}