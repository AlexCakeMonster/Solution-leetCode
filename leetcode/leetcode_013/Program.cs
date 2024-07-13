using System;
using System.Diagnostics;

namespace leetcode_013
{

    /*
     Hard

     Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.
     You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

    177 / 177 test cases passed.  Status: Accepted
    Runtime: 217 ms  - beats 79.09 % of csharp submissions.
    Memory Usage: 64.1 MB  - beats 19.29 % of csharp submissions.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().FirstMissingPositive(new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,17,19,20,21,22,23,24,25,26,27,28,29,30 }));            
        }
    }
   
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            System.Collections.Generic.HashSet<int> positiveNumbers = new System.Collections.Generic.HashSet<int>();

            int missingNumber = 1;
            int count = 0;

            foreach (var item in nums)
            {
                if(item > 0)
                {
                    positiveNumbers.Add(item);
                }
            }

            while (true)
            {

                if (!positiveNumbers.Contains(missingNumber))
                {
                    break;
                }
                missingNumber++;
                count++;
            }
            st.Stop();
            Console.WriteLine("Time :" + st.Elapsed);

            return missingNumber;
        }
    }

}
