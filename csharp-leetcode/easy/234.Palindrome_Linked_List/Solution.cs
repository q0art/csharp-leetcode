using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._234.Palindrome_Linked_List;

public class Solution
{
    private ListNode _listNode;
    
    public bool IsPalindrome(ListNode head)
    {
        _listNode = head;
        return IsPalindromeHelper(head);
    }

    private bool IsPalindromeHelper(ListNode node)
    {
        if (node == null)
        {
            return true;
        }

        bool result = IsPalindromeHelper(node.next) && (_listNode.val == node.val);
        _listNode = _listNode.next;

        return result;
    }
}