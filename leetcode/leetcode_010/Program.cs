using System;

namespace leetcode_010
{
    class Program
    {

        /*
        Hard

        Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays. 

        2094 / 2094 test cases passed.
        Status: Accepted
        Runtime: 83 ms - beats 93.51 % of csharp submissions.
        Memory Usage: 54.8 MB - beats 48.95 % of csharp submissions.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] {}, new int[] { -2, -1 }));
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double[] mergedArray = MergingArrays(nums1, nums2);
            double median;

            if((nums1.Length + nums2.Length) % 2 == 0)
            {                
                return median = (mergedArray[mergedArray.Length-1] + mergedArray[mergedArray.Length -2 ]) / 2;                
            }
            else
            {
                return median = mergedArray[mergedArray.Length -1 ];
            }
        }

        private double[] MergingArrays(int[] nums1, int[] nums2)
        {
            int maximumIndex = 0;
            double[] mergedArray;
            maximumIndex = (nums1.Length + nums2.Length) / 2;
            mergedArray = new double[maximumIndex + 1];
            
            int counter1 = 0, counter2 = 0, counterMA= 0;
            while (counter1 < nums1.Length && counter2 < nums2.Length && counterMA < mergedArray.Length)
            {
                if(nums1[counter1] < nums2[counter2])
                {
                    mergedArray[counterMA] = nums1[counter1];
                    counterMA++;
                    counter1++;
                }
                else
                {
                    mergedArray[counterMA] = nums2[counter2];
                    counterMA++;
                    counter2++;
                }
            }

            while(counter1 < nums1.Length && counterMA < mergedArray.Length)
            {
                mergedArray[counterMA] = nums1[counter1];
                counterMA++;
                counter1++;
            }

            while (counter2 < nums2.Length && counterMA < mergedArray.Length)
            {
                mergedArray[counterMA] = nums2[counter2];
                counterMA++;
                counter2++;
            }

            return mergedArray;
        }

        
    }
}
