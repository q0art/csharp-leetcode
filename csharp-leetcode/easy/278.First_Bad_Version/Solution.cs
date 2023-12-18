namespace csharp_leetcode.easy._278.First_Bad_Version;

public class VersionControl
{
    public bool IsBadVersion(int n) => throw new NotImplementedException();
}

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 0, right = n;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (IsBadVersion(mid))
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
}
