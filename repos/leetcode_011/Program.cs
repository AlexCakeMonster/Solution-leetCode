using System;

namespace leetcode_011
{
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
