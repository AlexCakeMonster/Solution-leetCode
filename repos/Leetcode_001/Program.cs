using System;
using System.Diagnostics;

namespace Leetcode_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(1234554321));

            Solution1 solution1 = new Solution1();
            Console.WriteLine(solution1.IsPalindrome1(1234554321));

        }

        public class Solution
        {
            public bool IsPalindrome(int x)
            {               
               
                int originalNumber = x;
                int reversedNumber = 0;
                int firstCharacterOfNmber = 0;

                while (x > 0)
                {
                    firstCharacterOfNmber = x % 10;
                    reversedNumber = reversedNumber * 10 + firstCharacterOfNmber;
                    x /= 10;
                }
               
                return originalNumber == reversedNumber;
            }

            static int[] NumberToArray(int value)
            {

                int numDigits = (int)Math.Floor(Math.Log10(value) + 1);
                int[] digits = new int[numDigits];

                for (int i = numDigits - 1; i >= 0; i--)
                {
                    digits[i] = value % 10;
                    value /= 10;
                }

                return digits;
            }


        }

        public class Solution1
        {
            public bool IsPalindrome1(int x)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (x < 0)
                {
                    return false;
                }

                string q = x.ToString();

                for (int i = 0; i < q.Length; i++)
                {
                    if (q[i] != q[q.Length - i - 1])
                    {
                        return false;
                    }
                }
                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);

                return true;


            }


        }
    }
}
