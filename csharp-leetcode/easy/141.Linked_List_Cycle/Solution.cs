using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._141.Linked_List_Cycle;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var hashSet = new HashSet<ListNode>();

        while (head != null)
        {
            if (head.next != null && hashSet.Contains(head.next))
            {
                return true;
            }

            hashSet.Add(head);
            head = head.next;
        }

        return false;
    }
}