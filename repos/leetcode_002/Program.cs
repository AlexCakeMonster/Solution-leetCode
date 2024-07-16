using System;

namespace leetcode_002
{
    class Program
    {
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
