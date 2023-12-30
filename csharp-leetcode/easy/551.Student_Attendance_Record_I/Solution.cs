namespace csharp_leetcode.easy._551.Student_Attendance_Record_I;

public class Solution
{
    public bool CheckRecord(string s) => s.IndexOf("A") == s.LastIndexOf("A") && !s.Contains("LLL");
}