using System.Text;

namespace csharp_leetcode.easy._412.Fizz_Buzz;

public class Solution 
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            var s = new StringBuilder();

            if (i % 3 == 0)
                s.Append("Fizz");

            if (i % 5 == 0)
                s.Append("Buzz");
            
            list.Add(s.Length == 0 ? i.ToString() : s.ToString());
        }

        return list;
    }
}