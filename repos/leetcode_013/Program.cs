using System;
using System.Diagnostics;

namespace leetcode_013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().FirstMissingPositive(new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,17,18,19,20,21,22,23,24,25,26,27,28,29,30 }));
            Console.WriteLine(new Solution1().FirstMissingPositive(new int[] {1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,17,18,19,20,21,22,23,24,25,26,27,28,29,30 }));
        }
    }

    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            int missingNumber = 1;
            int count = 0;
            while (count-1<nums.Length)
            {
                
                if (Array.IndexOf(nums, missingNumber) == -1)
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
    public class Solution1
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
