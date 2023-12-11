using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._83.Remove_Duplicates_from_Sorted_List;

public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode current = head;

        while (current != null && current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}