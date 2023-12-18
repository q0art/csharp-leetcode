using csharp_leetcode.helpers;

namespace csharp_leetcode.easy._21.Merge_Two_Sorted_Lists;

public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null)
            return list2;

        if (list2 == null)
            return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);

            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);

            return list2;
        }
    }
}