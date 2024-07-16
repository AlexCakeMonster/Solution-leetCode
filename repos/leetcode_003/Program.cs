using System;
using System.Collections.Generic;

namespace leetcode_003

  /*  Given a string s, return the longest palindromic substring in s.
    Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.
    Example 2:
    Input: s = "cbbd"
    Output: "bb"*/

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestPalindrome("clclcl"));
            Console.WriteLine(new Solution().LongestPalindrome1("clclcl"));            
            Console.WriteLine(new Solution().LongestPalindrome2("clclcl"));
        }
            
    }

    public class Solution
    {
        // First solution: 380 milliseconds
        public string LongestPalindrome1(string s)
        {
            string minPolidrom = "";
            string maxPolidrom = "";

            for (int i = 0; i < s.Length; i++)
            {
                int j = 1;

                minPolidrom += s[i];
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    j = 1;
                    minPolidrom += s[i + 1];

                    while (i - j >= 0 && i + j + 1 < s.Length && s[i - j] == s[i + j + 1])
                    {
                        minPolidrom = s[i - j] + minPolidrom + s[i + j + 1];
                        j++;
                    }
                }

                if (maxPolidrom.Length < minPolidrom.Length)
                    maxPolidrom = minPolidrom;

                minPolidrom = "";

                minPolidrom += s[i];

                j = 1;


                while (i - j >= 0 && i + j < s.Length && s[i - j] == s[i + j])
                {
                    minPolidrom = s[i - j] + minPolidrom + s[i + j];
                    j++;
                }

                if (maxPolidrom.Length < minPolidrom.Length)
                    maxPolidrom = minPolidrom;

                minPolidrom = "";
            }

            return maxPolidrom;
        }

        #region Second solution: 280 milliseconds
        public string LongestPalindrome(string s)
        {            
            string polidromFirstAlgorithm = "";
            string polidromSecondAlgorithm = "";
            string maxPolidrom = "";

            for (int i = 0; i < s.Length; i++)
            {                            
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    polidromFirstAlgorithm = PolydromeSearchAlgorithm(i, 1, s);
                }

                polidromSecondAlgorithm = PolydromeSearchAlgorithm(i, 0, s);

                if (polidromFirstAlgorithm.Length > polidromSecondAlgorithm.Length)
                {
                    if(polidromFirstAlgorithm.Length > maxPolidrom.Length)
                        maxPolidrom = polidromFirstAlgorithm;
                }
                else
                {
                    if(polidromSecondAlgorithm.Length > maxPolidrom.Length)
                        maxPolidrom = polidromSecondAlgorithm;
                }                                  

            }
            return maxPolidrom;
            
        }

        private string PolydromeSearchAlgorithm(int index, int searchVariable, string value)
        {
            System.Text.StringBuilder minPolidrom = new System.Text.StringBuilder();
            System.Text.StringBuilder maxPolidrom = new System.Text.StringBuilder();            
            int i = index;
            int searchIndex = 1;            
            minPolidrom.Append(value[i]);

            if (searchVariable == 1)
                minPolidrom.Append(value[i + searchVariable]);

            while (i - searchIndex >= 0 && i + searchIndex + searchVariable < value.Length && value[i - searchIndex] == value[i + searchIndex + searchVariable])
            {
                minPolidrom.Insert(0, value[i - searchIndex]);
                minPolidrom.Append(value[i + searchIndex + searchVariable]);
                searchIndex++;
            }

            if (maxPolidrom.Length > minPolidrom.Length)
                return maxPolidrom.ToString();
            else
                return minPolidrom.ToString();

        }
        #endregion

        #region Third solution: 76 milliseconds
        public string LongestPalindrome2(string s)
        {
            (int indexStart, int palindromeLength) polidromFirstAlgorithm = (0,0);
            (int indexStart, int palindromeLength) polidromSecondAlgorithm = (0,0);
            (int indexStart, int palindromeLength) maxPolidrom  = (0,0);

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    polidromFirstAlgorithm = PolydromeSearchAlgorithm1(i, 1, s);
                }

                polidromSecondAlgorithm = PolydromeSearchAlgorithm1(i, 0, s);

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

        private (int,int) PolydromeSearchAlgorithm1(int index, int searchVariable, string value)
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

        #endregion

    }
}
