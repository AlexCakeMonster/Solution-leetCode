using System;

namespace leetcode_002
{
    class Program
    {
        /*
        Easy

        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.

        
        98 / 98 test cases passed.
        Status: Accepted
        Runtime: 63 ms  - beats 25.59 % of csharp submissions.
        Memory Usage: 39.8 MB  beats 39.26 % of csharp submissions.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsValid("(}}}"));
            Console.WriteLine(new Solution().IsValid1("(}}}"));
        }
    }

    public class Solution
    {
        
        public bool IsValid(string s)
        {           
            
            System.Collections.Generic.List<char> sList = new System.Collections.Generic.List<char>();

            foreach (char el in s)
            {
                sList.Add(el);
            }

            int cownt = 0;
            while (cownt < sList.Count)
            {
                if (cownt + 1 < sList.Count)
                {
                    switch (sList[cownt])
                    {
                        case '[':
                            if (sList[cownt + 1] == ']')
                            {
                                sList.RemoveAt(cownt);
                                sList.RemoveAt(cownt);
                                cownt = 0;                                
                            }
                            else
                                cownt++;
                            break;
                        case '{':
                            if (sList[cownt + 1] == '}')
                            {
                                sList.RemoveAt(cownt);
                                sList.RemoveAt(cownt);
                                cownt = 0;                                
                            }
                            else
                                cownt++;
                            break;
                        case '(':
                            if (sList[cownt + 1] == ')')
                            {
                                sList.RemoveAt(cownt);
                                sList.RemoveAt(cownt);
                                cownt = 0;                                
                            }
                            else
                                cownt++;
                            break;
                        default:
                            cownt++;
                            break;
                    }
                }
                else
                {
                    return false;
                }               
                               
            }

            if (sList.Count == 0)
                return true;
            else
                return false;
        }

        public bool IsValid1(string s)
        {                        

            int cownt = 0;
            while (cownt < s.Length)
            {
                if (cownt + 1 < s.Length)
                {
                    switch (s[cownt])
                    {
                        case '[':
                            if (s[cownt + 1] == ']')
                            {
                                s = s.Remove(cownt, 2);                                
                                cownt = 0;
                            }
                            else
                                cownt++;
                            break;
                        case '{':
                            if (s[cownt + 1] == '}')
                            {
                                s = s.Remove(cownt, 2);
                                cownt = 0;
                            }
                            else
                                cownt++;
                            break;
                        case '(':
                            if (s[cownt + 1] == ')')
                            {
                                s = s.Remove(cownt, 2);
                                cownt = 0;
                            }
                            else
                                cownt++;
                            break;
                        default:
                            cownt++;
                            break;
                    }
                }
                else
                {
                    return false;
                }

            }

            if (s.Length == 0)
                return true;
            else
                return false;
        }
    }

    
}
