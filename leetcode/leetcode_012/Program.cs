using System;
using System.Diagnostics;

namespace leetcode_012
{
    class Program
    {
        /*
        Medium

        You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
        Find two lines that together with the x-axis form a container, such that the container contains the most water.
        Return the maximum amount of water a container can store.
        Notice that you may not slant the container.

        
        62 / 62 test cases passed.  Status: Accepted
        Runtime: 358 ms - the problem is not completely solved - with a large set of elements, calculations take quite a long time
        Memory Usage: 61.6 MB - beats 88.86 % of csharp submissions.
         */

        // TODO: rework the algorithm to improve performance
        static void Main(string[] args)
        {

            int[] i = new int[] { 3690, 7683, 9156, 8637, 6242, 1881, 9505, 3803, 3840, 7101, 3490};
            
            Console.WriteLine(new Solution().MaxArea(i));
            
           
        }
    }

    public class Solution
    {


        public int MaxArea(int[] height)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            int result = 0;
            int max = 0;
            int count1 = 0, count2 = height.Length - 1;

            while (count1 < height.Length - 1)
            {
                if (height[count1] < height[count1+1])
                {
                    count1++;
                    continue;
                }

                count2 = height.Length - 1;

                while (count2 > count1)
                {

                    if (height[count1] <= height[count2])
                    {
                        result = (count2 - count1) * height[count1];
                    }
                    else
                    {
                        result = (count2 - count1) * height[count2];
                    }

                    if (result > max)
                        max = result;

                    count2--;
                }
                count1++;
            }
            return max;
        }
    }
}

    