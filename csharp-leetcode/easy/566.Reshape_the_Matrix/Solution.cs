namespace csharp_leetcode.easy._566.Reshape_the_Matrix;

public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (r * c != mat.Length * mat[0].Length)
            return mat;

        int[][] matrix = new int[r][];

        for (int i = 0; i < r; i++)
            matrix[i] = new int[c];

        for (int i = 0; i < r * c; i++)
            matrix[i / c][i % c] = mat[i / mat[0].Length][i % mat[0].Length];

        return matrix;
    }
}