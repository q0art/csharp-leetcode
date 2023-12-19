namespace csharp_leetcode.easy._345.Reverse_Vowels_of_a_String;

public class Solution
{
    public string ReverseVowels(string s)
    {
        var hashSet = new HashSet<char>() {'e', 'E', 'u', 'U', 'i', 'I', 'o', 'O', 'a', 'A'};
        var array = s.ToCharArray();
        int left = 0, right = array.Length - 1;

        while (left < right)
        {
            while (left < right && !hashSet.Contains(array[left]))
                left++;

            while (left < right && !hashSet.Contains(array[right]))
                right--;

            if (left < right)
            {
                char temp = array[left];
                array[left++] = array[right];
                array[right--] = temp;
            }
        }

        return new string(array);
    }
}