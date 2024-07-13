using System;
using System.Collections.Generic;

namespace leetcode_003

{
    /*
     Medium

    Given a string s, return the longest palindromic substring in s.
    Example:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

    
    142 / 142 test cases passed. Status: Accepted
    Runtime: 79 ms - beats 71.31 % of csharp submissions.
    Memory Usage: 40.4 MB - beats 63.28 % of csharp submissions.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestPalindrome("babad"));
            Console.WriteLine(new Solution().LongestPalindrome("clclcl"));          
           
        }
            
    }

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            (int indexStart, int palindromeLength) polidromFirstAlgorithm = (0, 0);
            (int indexStart, int palindromeLength) polidromSecondAlgorithm = (0, 0);
            (int indexStart, int palindromeLength) maxPolidrom = (0, 0);

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    polidromFirstAlgorithm = PolydromeSearchAlgorithm(i, 1, s);
                }

                polidromSecondAlgorithm = PolydromeSearchAlgorithm(i, 0, s);

                if (polidromFirstAlgorithm.palindromeLength > polidromSecondAlgorithm.palindromeLength)
                {
                    if (polidromFirstAlgorithm.palindromeLength > maxPolidrom.palindromeLength)
                        maxPolidrom = polidromFirstAlgorithm;
                }
                else
                {
                    if (polidromSecondAlgorithm.palindromeLength > maxPolidrom.palindromeLength)
                        maxPolidrom = polidromSecondAlgorithm;
                }

            }
            return s.Substring(maxPolidrom.indexStart, maxPolidrom.palindromeLength);

        }

        private (int, int) PolydromeSearchAlgorithm(int index, int searchVariable, string value)
        {
            int indexStart = index;
            int palindromeLength = 0;
            int i = index;
            int searchIndex = 1;
            palindromeLength++;

            if (searchVariable == 1)
                palindromeLength++;

            while (i - searchIndex >= 0 && i + searchIndex + searchVariable < value.Length && value[i - searchIndex] == value[i + searchIndex + searchVariable])
            {
                indexStart = i - searchIndex;
                palindromeLength += 2;
                searchIndex++;
            }

            return (indexStart, palindromeLength);


        }

    }
}
