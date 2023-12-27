namespace csharp_leetcode.easy._500.Keyboard_Row;

public class Solution
{
    public string[] FindWords(string[] words)
    {
        var array = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        var list = new List<string>();

        foreach (var word in words)
        {
            if (array.Any(row => word.All(c => row.Contains(char.ToLower(c)))))
                list.Add(word);
        }

        return list.ToArray();
    }
}