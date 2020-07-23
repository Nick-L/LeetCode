using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using LeetCode.Shared;


namespace LeetCodeTests
{
    [TestClass]
    public class AddTwoNumbersTests
    {
        [TestMethod]
        public void ExampleImput()
        {
            ListNode first = new ListNode(new int[] { 2, 4, 3 });
            ListNode second = new ListNode(new int[] { 5, 6, 4 });

            ListNode answer = AddTwoNumbers.LinkedListSum(first, second);

            Assert.IsTrue(ListNode.CompareSingleLinkedList(answer, new ListNode(new int[] { 7, 0, 8 })));
        }

        /*
         * First failed test case on LeetCode
         * Failed due to carry bypassing value 
         * expected [0, 9] was [0,8,1]
         */
        [TestMethod]
        public void CarryBypassOfValue()
        {
            ListNode first = new ListNode(new int[] { 9, 8 });
            ListNode second = new ListNode(new int[] { 1 });

            ListNode answer = AddTwoNumbers.LinkedListSum(first, second);

            Assert.IsTrue(ListNode.CompareSingleLinkedList(answer, new ListNode(new int[] { 0, 9 })));
        }

        /*
         * Second Failed  test case
         * Failed due to carry going beyond 10
         * expected [0, 0, 1] was [0, 10]
         */
        [TestMethod]
        public void ValueGreaterThan9()
        {
            ListNode first = new ListNode(new int[] { 1 });
            ListNode second = new ListNode(new int[] { 9, 9 });

            ListNode answer = AddTwoNumbers.LinkedListSum(first, second);

            Assert.IsTrue(ListNode.CompareSingleLinkedList(answer, new ListNode(new int[] { 0, 0, 1 })));
        }
    }
}
