using System;

namespace leetcode_011
{
    /*
    Medium

    Given a signed 32-bit integer x, return x with its digits reversed.
    If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.

    1045 / 1045 test cases passed.
    Status: Accepted
    Runtime: 25 ms  - beats 41.33 % of csharp submissions.
    Memory Usage: 28.4 MB -  beats 21.03 % of csharp submissions.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().Reverse(-120));
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int originalNumber = x;
            int reverseNumber = 0;
            int intermediateValue = 0;

            try
            {
                checked
                {
                    while (originalNumber > 0)
                    {
                        intermediateValue = originalNumber % 10;
                        reverseNumber = reverseNumber * 10 + intermediateValue;
                        originalNumber /= 10;
                    }

                    while (originalNumber < 0)
                    {
                        intermediateValue = originalNumber % 10;
                        reverseNumber = reverseNumber * 10 + intermediateValue;
                        originalNumber /= 10;
                    }
                    return reverseNumber;
                }
               
            }
            catch
            {
                return 0;
            }
            
        }
    }
}
