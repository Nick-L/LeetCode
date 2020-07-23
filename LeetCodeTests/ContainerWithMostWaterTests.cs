using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using LeetCode.Shared;

namespace LeetCodeTests
{
    [TestClass]
    public class ContainerWithMostWaterTests
    {
        [TestMethod]
        public void ExampleInput_BruteForce()
        {
            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            const int expectedValue = 49;
            
            Assert.AreEqual(ContainerWithMostWater.MaxAreaBruteForce(input), expectedValue);
        }

        /*
         * Failed test due to timeout (test works here as more processing power and no timeout)
         */
        [TestMethod]
        public void LargeArrayTimeOut_BruteForce()
        {
            int[] input = GenerateVeryLargeArray();
            const int expectedValue = 56250000;

            Assert.AreEqual(ContainerWithMostWater.MaxAreaBruteForce(input), expectedValue);
        }

        [TestMethod]
        public void ExampleInput_TwoPointer()
        {
            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            const int expectedValue = 49;

            Assert.AreEqual(ContainerWithMostWater.MaxAreaTwoPointer(input), expectedValue);
        }

        [TestMethod]
        public void LargeArrayTimeOut_TwoPointer()
        {
            int[] input = GenerateVeryLargeArray();
            const int expectedValue = 56250000;

            Assert.AreEqual(ContainerWithMostWater.MaxAreaTwoPointer(input), expectedValue);
        }

        private int[] GenerateVeryLargeArray()
        {
            int[] array = new int[15000];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 15000 - i;
            }

            return array;
        }
    }
}
