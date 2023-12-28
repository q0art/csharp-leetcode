namespace csharp_leetcode.easy._520.Detect_Capital;

public class Solution
{
    public bool DetectCapitalUse(string word) => word.All(char.IsUpper)
                                                 || word.Skip(1).All(char.IsLower);
}