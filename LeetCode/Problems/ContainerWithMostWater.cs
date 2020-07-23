using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class ContainerWithMostWater
    {
        public static int MaxAreaBruteForce(int[] height)
        {
            int maxArea = 0;
            int area;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    area = Math.Abs(i - j) * Math.Min(height[i], height[j]);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }

            return maxArea;
        }
        
        /*
         * Added more efficient way to solve the problem after final test case timed out
         */
        public static int MaxAreaTwoPointer(int[] height)
        {
            int maxArea = 0;
            int area;

            int start = 0;
            int end = height.Length - 1;

            while (start != end)
            {
                area = (end - start) * Math.Min(height[start], height[end]);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return maxArea;
        }
    }
}
