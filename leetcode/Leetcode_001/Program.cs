using System;
using System.Diagnostics;

namespace Leetcode_001
{
    class Program
    {
        /*
        Given an integer x, return true if x is a palindrome, and false otherwise.
        
        11511 / 11511 test cases passed. Status: Accepted
        Runtime: 44 ms - Runtime: 44 ms - beats 75.49 % of csharp submissions.
        Memory Usage: 31.7 MB - Memory Usage: 31.7 MB - beats 80.84 % of csharp submissions.
         */
        static void Main(string[] args)
        {            
            Console.WriteLine(new Solution().IsPalindrome(1234554321));         
        }        
        
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

    }
}
