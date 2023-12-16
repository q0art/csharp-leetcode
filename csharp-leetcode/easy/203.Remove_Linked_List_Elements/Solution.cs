using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._203.Remove_Linked_List_Elements;

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val) 
    {
        if (head == null)
        {
            return null;
        }

        head.next = RemoveElements(head.next, val);

        return head.val == val ? head.next : head;
    }
}