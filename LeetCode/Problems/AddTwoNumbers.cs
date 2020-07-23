using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Shared;

namespace LeetCode.Problems
{
    public static class AddTwoNumbers
    {
        public static ListNode LinkedListSum(ListNode l1, ListNode l2)
        {
            ListNode ret = new ListNode();
            int carry = 0;
            int val;

            ListNode node = ret;

            while (l1 != null)
            {
                if (l2 != null)
                {
                    val = l1.val + l2.val + carry;
                    carry = val / 10;
                    node.val = val - (carry * 10);

                    l1 = l1.next;
                    l2 = l2.next;
                }
                else
                {
                    val = l1.val + carry;
                    carry = val / 10;
                    node.val = val - (carry * 10);

                    l1 = l1.next;
                }

                if (l1 != null)
                {
                    node.next = new ListNode();
                    node = node.next;
                }

            }

            if (l2 != null)
            {
                while (l2 != null)
                {
                    val = l2.val + carry;

                    carry = val / 10;
                    node.next = new ListNode(val - (carry * 10), null);
                    node = node.next;

                    l2 = l2.next;
                }
            }

            if (carry != 0 && l1 == null && l2 == null)
            {
                node.next = new ListNode(carry, null);
            }

            return ret;

        }
    }
}
