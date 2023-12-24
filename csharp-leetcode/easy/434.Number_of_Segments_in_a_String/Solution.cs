namespace csharp_leetcode.easy._434.Number_of_Segments_in_a_String;

public class Solution
{
    public int CountSegments(string s) => s.Split(' ').Where(i => i != "").Count();
}