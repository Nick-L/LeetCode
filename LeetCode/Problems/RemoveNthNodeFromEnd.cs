using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class RemoveNthNodeFromEnd
    {
        public static ListNode ListRemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode leadingNode = dummy;
            ListNode trailingNode = dummy;

            for (int i = 0; i < n; i++)
            {
                leadingNode = leadingNode.next;
            }

            if (leadingNode == null)
            {
                return null;
            }

            while (leadingNode != null && leadingNode.next != null)
            {
                leadingNode = leadingNode.next;
                trailingNode = trailingNode.next;
            }

            trailingNode.next = trailingNode.next.next;

            return dummy.next;

        }
    }
}
