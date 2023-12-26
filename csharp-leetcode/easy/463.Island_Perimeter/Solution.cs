namespace csharp_leetcode.easy._463.Island_Perimeter;

public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    result += 4;

                    if (i - 1 >= 0 && grid[i - 1][j] == 1)
                        result -= 2;

                    if (j - 1 >= 0 && grid[i][j - 1] == 1)
                        result -= 2;
                }
            }
        }

        return result;
    }
}