namespace csharp_leetcode.easy._383.Ransom_Note;

public class Solution
{
    public bool CanConstruct(string firstString, string secondString)
    {
        var list = new List<char>(secondString);

        for (int i = 0; i < firstString.Length; i++)
            if (!list.Remove(firstString[i]))
                return false;

        return true;
    }
}