namespace csharp_leetcode.easy._492.Construct_the_Rectangle;

public class Solution
{
    public int[] ConstructRectangle(int area)
    {
        int width = (int)Math.Sqrt(area);

        while (area % width > 0)
            width--;

        return new int[] { area / width, width };
    }
}