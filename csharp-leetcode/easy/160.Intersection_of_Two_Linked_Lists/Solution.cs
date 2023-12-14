using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._160.Intersection_of_Two_Linked_Lists;

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int lengthA = GetIntersectionNodeHelper(headA),
            lengthB = GetIntersectionNodeHelper(headB);

        while (lengthA > lengthB)
        {
            headA = headA.next;
            lengthA--;
        }

        while (lengthB > lengthA)
        {
            headB = headB.next;
            lengthB--;
        }

        while (headA != headB)
        {
            headA = headA.next;
            headB = headB.next;
        }

        return headA;
    }

    private int GetIntersectionNodeHelper(ListNode head)
    {
        int length = 0;

        while (head != null)
        {
            length++;
            head = head.next;
        }

        return length;
    }
}