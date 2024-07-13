using System;


namespace leetcode_009
{
    class Program
    {
        /*
        Hard
        Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
        '?' Matches any single character.
        '*' Matches any sequence of characters (including the empty sequence).
        The matching should cover the entire input string (not partial).

        Not a solution
         */
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsMatch("adceb", "*a*b"));  // true
            Console.WriteLine(new Solution().IsMatch("", "******"));     // true
            Console.WriteLine(new Solution().IsMatch("aa", "a"));        // f
            Console.WriteLine(new Solution().IsMatch("aa", "*"));        // true
            Console.WriteLine(new Solution().IsMatch("cb", "?a"));       // f
            Console.WriteLine(new Solution().IsMatch("acdcb", "a*c?b")); // f
        }
    }
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {               
            
            bool[] isCheckPEl = new bool[p.Length];
            int count = s.Length;
            int missingCharacters = 0;
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(j < p.Length)
                {
                    if (s[i] == p[j] && !isCheckPEl[j])
                    {
                        if (j - 1 >= 0)
                        {
                            if (p[j - 1] == '*' && isCheckPEl[j - 1] == false)
                            {
                                isCheckPEl[j - 1] = true;
                                count -= missingCharacters;
                                missingCharacters = 0;
                                isCheckPEl[j] = true;
                                j++;
                                continue;
                            }
                        }
                        isCheckPEl[j] = true;
                        count--;
                        j++;
                        continue;
                    }
                    else if (p[j] == '?' && !isCheckPEl[j])
                    {
                        isCheckPEl[j] = true;
                        count--;
                        j++;
                        continue;
                    }
                    else if (j + 1 < p.Length && s[i] == p[j+1] && p[j] == '*' && !isCheckPEl[j])
                    {
                        j++;
                        missingCharacters++;
                        continue;
                    }
                    else if (p[j] == '*' && !isCheckPEl[j])
                    {                      
                        
                        missingCharacters++;
                    }

                }               

                
            }

                Console.WriteLine(count);
            if (count == 0)
                return true;
            else
                return false;
        }
    }

    
    public class Solution1
    {
            public bool IsMatch(string s, string p)
            {
                System.Collections.Generic.Stack<char> charactersWithoutMatchesS = new System.Collections.Generic.Stack<char>();
                System.Collections.Generic.Stack<char> charactersWithoutMatchesP = new System.Collections.Generic.Stack<char>();

                bool isCharFound;
                if (p[0] == '*')
                {
                    s = new string('-', 1) + s;
                }


                if (s.Length < p.Length)
                    s = s + new string('-', p.Length - s.Length);



                bool[] isCheckPEl = new bool[p.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    isCharFound = false;

                    for (int j = 0; j < p.Length; j++)
                    {
                        if (s[i] == p[j] && !isCheckPEl[j])
                        {
                            isCheckPEl[j] = true;
                            isCharFound = true;
                            break;
                        }

                        if ((p[j] == '*' || p[j] == '?') && !isCheckPEl[j])
                        {
                            charactersWithoutMatchesP.Push(p[j]);
                            isCheckPEl[j] = true;
                        }

                    }

                    if (!isCharFound)
                        charactersWithoutMatchesS.Push(s[i]);

                }

                while (Math.Min(charactersWithoutMatchesP.Count, charactersWithoutMatchesS.Count) != 0)
                {
                    if (charactersWithoutMatchesP.Peek() == '*' && charactersWithoutMatchesS.Peek() == '-')
                    {
                        charactersWithoutMatchesP.Pop();
                        charactersWithoutMatchesS.Pop();
                    }
                    else if (charactersWithoutMatchesP.Peek() == '*' && charactersWithoutMatchesS.Peek() != '-')
                    {
                        charactersWithoutMatchesS.Pop();
                    }
                    else if (charactersWithoutMatchesP.Peek() == '?' && charactersWithoutMatchesS.Peek() != '-')
                    {
                        charactersWithoutMatchesP.Pop();
                        charactersWithoutMatchesS.Pop();
                    }
                }

                if (charactersWithoutMatchesS.Count == 0)
                    return true;



                return false;
            }
        }
   
}
