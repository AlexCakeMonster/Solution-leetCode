using System;


namespace Leetcode
{
    class Program
    {
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
