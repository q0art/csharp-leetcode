namespace csharp_leetcode.easy._118.Pascal_s_Triangle;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            var listRow = new List<int>();
            
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || j == i)
                {
                    listRow.Add(1);
                }
                else
                {
                    listRow.Add(list[i - 1][j - 1] + list[i - 1][j]);
                }
            }
            
            list.Add(listRow);
        }

        return list;
    }
}