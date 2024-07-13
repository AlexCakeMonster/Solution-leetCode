using System;


namespace Leetcode
{
    class Program
    {
        /*
        Easy

        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        
        63 / 63 test cases passed.
        Status: Accepted
        Runtime: 141 ms - beats 31.09 % of csharp submissions.
        Memory Usage: 47.7 MB  - beats 48.74 % of csharp submissions.
         */
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] twoSum = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            Console.WriteLine(twoSum[0] + "+" + twoSum[1] + "= 6");
        }
    }

    public class Solution
    {
        
        public int[] TwoSum(int[] nums, int target)
        {
            int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i +1; j< nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {                        
                        twoSum[0] = i;
                        twoSum[1] = j;
                        break;
                    }
                }
            }
            return twoSum;
        }
    }
}
