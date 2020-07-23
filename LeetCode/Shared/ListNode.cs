using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Shared
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] array)
        {
            this.val = array[0];
            ListNode temp = this;

            for (int i = 1; i < array.Length; i++)
            {
                temp.next = new ListNode(array[i]);
                temp = temp.next;
            }
        }

        public static bool CompareSingleLinkedList(ListNode first, ListNode second)
        {
            while (first.next != null && second.next != null)
            {
                if (first.val == second.val)
                {
                    first = first.next;
                    second = second.next;
                }
                else
                {
                    return false;
                }
            }

            if (first.next != null ^ second.next != null)
            {
                return false;
            }

            return true;
        }
    }
}
