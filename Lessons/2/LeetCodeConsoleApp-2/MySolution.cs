using System.Runtime.InteropServices.JavaScript;

namespace LeetCodeConsoleApp_2;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class MySolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        List<int> r1 = new List<int>();
        Int128 mult = 1;
        int per = 0, v1, v2;
        
        while (l1 != null || l2 != null)
        {
            v1 = 0;
            v2 = 0;
            if (l1 != null)
            {
                v1 = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                v2 = l2.val;
                l2 = l2.next;
            }
            int sum = v1 + v2 + per;
            int n = sum % 10;
            per = sum / 10;
            r1.Add(n);
        }

        if(per != 0)
            r1.Add(per);
        ListNode next = null;  
        foreach (var i in r1.ToArray().Reverse())
        {
            ListNode ln = new ListNode(i, next);
            next = ln;
        }
        return next;

    }
}