namespace csharp_leetcode.easy._605.Can_Place_Flowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (var i = 0; i < flowerbed.Length; i++)
            if (flowerbed[i] == 0 &&
                flowerbed.ElementAtOrDefault(i + 1) == 0 &&
                flowerbed.ElementAtOrDefault(i - 1) == 0)
            {
                n--;
                flowerbed[i] = 1;
            }

        return n <= 0;
    }
}