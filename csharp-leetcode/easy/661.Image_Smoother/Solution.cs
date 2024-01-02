namespace csharp_leetcode.easy._661.Image_Smoother;

public class Solution
{
    public int[][] ImageSmoother(int[][] img)
    {
        int m = img.Length, n = img[0].Length;
        var array = new int[m][];

        for (int i = 0; i < m; i++)
        {
            array[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                int sum = 0, count = 0;

                for (int x = Math.Max(i - 1, 0); x < Math.Min(i + 2, m); x++)
                    for (int y = Math.Max(j - 1, 0); y < Math.Min(j + 2, n); y++)
                    {
                        sum += img[x][y];
                        count++;
                    }

                array[i][j] = sum / count;
            }
        }

        return array;
    }
}