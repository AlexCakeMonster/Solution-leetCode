using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace leetcode_006
{
    class Program
    {
        /*
        Hard

        Given a string containing just the characters '(' and ')',
        return the length of the longest valid (well-formed) parentheses substring.
        
        231 / 231 test cases passed.  Status: Accepted
        Runtime: 52 ms - beats 53.93 % of csharp submissions.
        Memory Usage: 39.1 MB - beats 81.94 % of csharp submissions.
         */
        static void Main(string[] args)
        {

            Console.WriteLine(new Solution().LongestValidParentheses("())(())(()(((((())()())()())()((()(((()()))())(((()()(((())())))()()))))(()))))))(((((((())))(())(())(()()((()))))))()((())))))(())))))(")); //76
            Console.WriteLine(new Solution().LongestValidParentheses("()(()"));  //2
            Console.WriteLine(new Solution().LongestValidParentheses("()(())")); //6
            Console.WriteLine(new Solution().LongestValidParentheses("((()())))()")); //8
            Console.WriteLine(new Solution().LongestValidParentheses(")()())")); //4
            Console.WriteLine(new Solution().LongestValidParentheses(")(((((()())()()))()(()))(")); //22
            Console.WriteLine(new Solution().LongestValidParentheses(")()(((())))(")); //10
            Console.WriteLine(new Solution().LongestValidParentheses("()(((()(()))))")); //14
            Console.WriteLine(new Solution().LongestValidParentheses("(()())")); //6
            Console.WriteLine(new Solution().LongestValidParentheses(")(()((((())")); //4  


        }
    }

    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            if (s.Length < 2)
            {
                return 0;
            }

            int intermediateResult = 0;
            int maxSubstringLength = 0;
            int count;
            bool[] isCheck = new bool[s.Length];
            bool elementChek = true;

            while (elementChek)
            {
                elementChek = false;

                for (int i = 0; i + 1 < s.Length; i++)
                {

                    count = i;

                    if ((isCheck[i] && isCheck[i + 1]) || s[i] == ')')
                    {
                        continue;
                    }


                    while (count < s.Length)
                    {

                        if (count + 1 < s.Length && !isCheck[count + 1])
                        {
                            if (s[i] != s[count + 1])
                            {
                                isCheck[i] = true;
                                isCheck[count + 1] = true;
                                elementChek = true;
                                if (i - 2 >= 0)
                                {
                                    i -= 2;
                                }
                                else
                                    i = count;

                                break;
                            }
                            else
                                break;
                        }

                        count++;
                    }

                }
            }


            for (int i = 0; i < isCheck.Length; i++)
            {
                if (isCheck[i])
                {
                    intermediateResult++;
                    if (maxSubstringLength < intermediateResult)
                    {
                        maxSubstringLength = intermediateResult;
                    }
                }
                else
                {
                    intermediateResult = 0;
                }
            }

            return maxSubstringLength;
        }
    }
}