namespace csharp_leetcode.easy._14.Longest_Common_Prefix;

public class Solution {
    public string LongestCommonPrefix(string[] s) {
        var result = s.First()
            .TakeWhile((v, i) => s.All(item => item.Length > i && item[i] == v));

        return new string(result.ToArray());
    }
}