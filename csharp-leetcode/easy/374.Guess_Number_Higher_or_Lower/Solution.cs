namespace csharp_leetcode.easy._374.Guess_Number_Higher_or_Lower;

public class GuessGame
{
    public int guess(int n) => throw new NotImplementedException();
}

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int left = 1, right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (guess(n) <= 0)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}