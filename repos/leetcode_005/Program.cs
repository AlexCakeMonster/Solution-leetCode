using System;

namespace leetcode_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestPalindrome("av")); //1
            Console.WriteLine(new Solution().LongestPalindrome("aab")); //2
            Console.WriteLine(new Solution().LongestPalindrome("dvdf")); //3
            Console.WriteLine(new Solution().LongestPalindrome("fffdgrhytuydugjghofuhvkjh")); //8
        }


        public class Solution
        {
            public int LongestPalindrome(string s)
            {
                if (s.Length < 1)
                    return 0;
                else if (s.Length < 2)
                    return 1;
                                              
                int maxsubstringLength = 0;
                int substringLength;
                bool breakWhile;
                bool cycleCompleted;
                int count;
                int vv = 0;

                char[] value = s.ToCharArray();



                for (int i = 1; i < value.Length; i++)
                {
                    count = i;
                    substringLength = count - vv;
                    breakWhile = false;
                    cycleCompleted = true;
                                       

                    while (count < value.Length)
                    {

                        for (int j = count - 1; j >= vv; j--)
                        {
                            if (value[count] == value[j])
                            {
                                vv = j+1;
                                breakWhile = true;
                                break;
                            }
                            cycleCompleted = true;
                        }

                        if (breakWhile || !cycleCompleted)
                            break;

                        count++;
                        substringLength++;
                        cycleCompleted = false;

                    }


                    if (substringLength > maxsubstringLength)
                    {                        
                        maxsubstringLength = substringLength;
                    }

                    
                    i = count;
                }

                return maxsubstringLength;

            }

            private int SubstringSearchAlgorithm(int index, string value)
            {                
                int substringLength = 1;
                bool breakWhile = false;
                bool cycleCompleted = true;
                int count = index;

                while (count < value.Length)
                {                                      

                    for (int i = count-1 ; i >= count - substringLength ; i--)
                    {                        
                        if (value[count] == value[i])
                        {
                            breakWhile = true;
                            break;
                        }                        
                        cycleCompleted = true;
                    }                    

                    if (breakWhile || !cycleCompleted)
                            return substringLength;

                    count++;
                    substringLength++;
                    cycleCompleted = false;

                }

                return substringLength;

            }
        }
        
    }
}
