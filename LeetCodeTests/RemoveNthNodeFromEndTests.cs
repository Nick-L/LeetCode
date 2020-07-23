using LeetCode.Problems;
using LeetCode.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestClass]
    public class RemoveNthNodeFromEndTests
    {
        [TestMethod]
        public void ExampleInput()
        {
            ListNode inputArray = new ListNode(new int[] { 1, 2, 3, 4, 5 });
            int inputN = 2;

            Assert.IsTrue(ListNode.CompareSingleLinkedList(RemoveNthNodeFromEnd.ListRemoveNthFromEnd(inputArray, inputN), new ListNode(new int[] { 1, 2, 3, 5 })));
        }

        /*
         * First failed test case on LeetCode
         * Failed due to removing the first node in the list
         * expected [2] was []
         */
        public void RemoveFirstNode()
        {
            ListNode inputArray = new ListNode(new int[] { 1, 2 });
            int inputN = 2;

            Assert.IsTrue(ListNode.CompareSingleLinkedList(RemoveNthNodeFromEnd.ListRemoveNthFromEnd(inputArray, inputN), new ListNode(new int[] { 2 })));
        }
    }
}
