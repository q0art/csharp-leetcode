namespace csharp_leetcode.easy._657.Robot_Return_to_Origin;

public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;
        
        foreach (char move in moves)
            if (move == 'U')
                y++;
            else if (move == 'D')
                y--;
            else if (move == 'L')
                x--;
            else if (move == 'R')
                x++;

        return x == 0 && y == 0;
    }
}