namespace csharp_leetcode.easy._682.Baseball_Game;

public class Solution
{
    public int CalPoints(string[] operations)
    {
        var list = new List<int>();

        foreach (var operation in operations)
            if (operation == "+")
                list.Add(list[^1] + list[^2]);
            else if (operation == "D")
                list.Add(list[^1] * 2);
            else if (operation == "C")
                list.Remove(list[^1]);
            else
                list.Add(int.Parse(operation));

        return list.Sum();
    }
}