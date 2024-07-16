using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace leetcode_006
{
    class Program
    {
        static void Main(string[] args)
        {          
                        
            Console.WriteLine(new Solution4().LongestValidParentheses("())(())(()(((((())()())()())()((()(((()()))())(((()()(((())())))()()))))(()))))))(((((((())))(())(())(()()((()))))))()((())))))(())))))("));
            Console.WriteLine(new Solution4().LongestValidParentheses("()(()"));  //2
            Console.WriteLine(new Solution4().LongestValidParentheses("()(())")); //6
            Console.WriteLine(new Solution4().LongestValidParentheses("((()())))()")); //8
            Console.WriteLine(new Solution4().LongestValidParentheses(")()())")); //4
            Console.WriteLine(new Solution4().LongestValidParentheses(")(((((()())()()))()(()))(")); //22
            Console.WriteLine(new Solution4().LongestValidParentheses(")()(((())))(")); //10
            Console.WriteLine(new Solution4().LongestValidParentheses("()(((()(()))))")); //14
            Console.WriteLine(new Solution4().LongestValidParentheses("(()())")); //6
            Console.WriteLine(new Solution4().LongestValidParentheses(")(()((((())")); //4  
             Console.WriteLine("_____________________________________");
            Console.WriteLine(new Solution5().LongestValidParentheses("())(())(()(((((())()())()())()((()(((()()))())(((()()(((())())))()()))))(()))))))(((((((())))(())(())(()()((()))))))()((())))))(())))))("));
            Console.WriteLine(new Solution5().LongestValidParentheses("()(()"));  //2
            Console.WriteLine(new Solution5().LongestValidParentheses("()(())")); //6
            Console.WriteLine(new Solution5().LongestValidParentheses("((()())))()")); //8
            Console.WriteLine(new Solution5().LongestValidParentheses(")()())")); //4
            Console.WriteLine(new Solution5().LongestValidParentheses(")(((((()())()()))()(()))(")); //22
            Console.WriteLine(new Solution5().LongestValidParentheses(")()(((())))(")); //10
            Console.WriteLine(new Solution5().LongestValidParentheses("()(((()(()))))")); //14
            Console.WriteLine(new Solution5().LongestValidParentheses("(()())")); //6
            Console.WriteLine(new Solution5().LongestValidParentheses(")(()((((())")); //4
           
        }
    }
   

    public class Solution
    {

        public int LongestValidParentheses(string s)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            if (s.Length < 2)
            {
                return 0;
            }

            int intermediateResult = 0;
            int maxSubstringLength = 0;
            int index = 0;
            bool elementChek = false;

            System.Collections.Generic.List<(char Value, int Index)> arrayChar = new System.Collections.Generic.List<(char Value, int Index)>();
            bool[] isCheck = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                arrayChar.Add((s[i], index));
                isCheck[i] = true;
                index++;
            }


            for (int i = 0; i < arrayChar.Count; i++)
            {
                while (true)
                {
                    elementChek = false;

                    if (i + 1 < arrayChar.Count && i >= 0 && arrayChar[i].Value == '(' && arrayChar[i + 1].Value != arrayChar[i].Value)
                    {
                        elementChek = true;
                        arrayChar.RemoveAt(i);
                        arrayChar.RemoveAt(i);
                    }
                    
                    if (i - 1 >= 0 && i < arrayChar.Count && arrayChar[i].Value == ')' && arrayChar[i - 1].Value != arrayChar[i].Value)
                    {
                        elementChek = true;
                        arrayChar.RemoveAt(i - 1);
                        arrayChar.RemoveAt(i - 1);
                        if (i - 1 >= 0)
                        {
                            i--;
                        }
                    }
                    
                    if(!elementChek)
                        break;
                }

            }

            if (arrayChar.Count == 0)
            {
                time.Stop();
                Console.Write($"==Solution: {time.Elapsed}==");
                return s.Length;
            }

            for (int i = 0; i < arrayChar.Count; i++)
            {
                isCheck[arrayChar[i].Index] = false;
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
            time.Stop();
            Console.Write($"==Solution: {time.Elapsed}==");
            return maxSubstringLength;
        }
    }

    public class Solution1
    {
        public int LongestValidParentheses(string s)
        {
            if (s.Length < 2)
            {
                return 0;
            }

            int intermediateResult = 0;
            int maxSubstringLength = 0;
            int index = 0;
            bool elementChek = false;

            System.Collections.Generic.List<(char Value, int Index)> arrayChar = new System.Collections.Generic.List<(char Value, int Index)>();
            bool[] isCheck = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                arrayChar.Add((s[i], index));
                isCheck[i] = true;
                index++;
            }


            for (int i = 0; i < arrayChar.Count; i++)
            {
                while (true)
                {
                    elementChek = false;

                    if (i + 1 < arrayChar.Count && i >= 0 && arrayChar[i].Value == '(' && arrayChar[i + 1].Value != arrayChar[i].Value)
                    {
                        elementChek = true;
                        arrayChar.RemoveAt(i);
                        arrayChar.RemoveAt(i);
                    }

                    if (i - 1 >= 0 && i < arrayChar.Count && arrayChar[i].Value == ')' && arrayChar[i - 1].Value != arrayChar[i].Value)
                    {
                        elementChek = true;
                        arrayChar.RemoveAt(i - 1);
                        arrayChar.RemoveAt(i - 1);
                        if (i - 1 >= 0)
                        {
                            i--;
                        }
                    }

                    if (!elementChek)
                        break;
                }

            }

            if (arrayChar.Count == 0)
            {
                return s.Length;
            }

            for (int i = 0; i < arrayChar.Count; i++)
            {
                isCheck[arrayChar[i].Index] = false;
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
    public class Solution3
    {
        public int LongestValidParentheses(string s)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            if (s.Length < 2)
            {
                return 0;
            }
            
            int intermediateResult = 0;
            int maxSubstringLength = 0;            
            int count2, count1;
            bool isArrayChanget;
            bool[] isCheck = new bool[s.Length];

            if(s.Length < 4)
            {
                for (int i = 0; i + 1 < s.Length; i++)
                {
                    if (s[i] == '(' && s[i+1] == ')')
                    {
                        isCheck[i] = true;
                        isCheck[i + 1] = true;
                    }
                }
            }
            
           
            for (int i = 0; i+1 < s.Length; i++)
            {
                if ((isCheck[i] && isCheck[i+1]) || s[i] == ')')
                {
                    continue;
                } 

                isArrayChanget = false;
                count2 = i+1;
                count1 = i;

               


                while (count2 < s.Length && count1 < s.Length)
                {
                    if (!isCheck[count1])
                    {
                        if (!isCheck[count2])
                        {
                            if (s[count1] == '(')
                            {
                                if (s[count1] != s[count2])
                                {
                                    isCheck[count1] = true;
                                    isCheck[count2] = true;
                                    count1 = count2 + 1;
                                    count2++;
                                    isArrayChanget = true;
                                }
                                else
                                {
                                    count1 = count2-1;
                                    count1++;
                                }                                

                            }
                            else
                            {
                                count2 = count1 + 1;
                                count1++;
                            }                             

                        }
                    }
                    else
                      count1++;


                    count2++;
                }

                if (isArrayChanget)
                {
                    i--;
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
            time.Stop();
            Console.Write($"==Solution3: {time.Elapsed}==");
            return maxSubstringLength;
        }
    }
    public class Solution4
    {
        public int LongestValidParentheses(string s)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            if (s.Length < 2)
            {
                return 0;
            }

            int intermediateResult = 0;
            int maxSubstringLength = 0;
            int count;
            bool[] isCheck = new bool[s.Length];


            for (int i = 0; i+1 < s.Length; i++)
            {

                count = i;

                if ((isCheck[i] && isCheck[i + 1]) || s[i] == ')' )
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
                            i = -1;
                            break;
                        }
                        else
                            break;
                    }

                    count++;
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
            time.Stop();
            Console.Write($"==Solution4: {time.Elapsed}==");
            return maxSubstringLength;
        }

    }

    public class Solution5
    {
        public int LongestValidParentheses(string s)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

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
                                if(i-2 >= 0)
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
            time.Stop();
            Console.Write($"==Solution5: {time.Elapsed}==");
            return maxSubstringLength;
        }

    }
}
