using System;

namespace leetcode_005
{
    class Program
    {

        /*
        Given a string s, find the length of the longest substring without repeating characters.
        Example:
        Input: s = "abcabcbb"
        Output: 3
        Explanation: The answer is "abc", with the length of 3.

        
        987 / 987 test cases passed. Status: Accepted
        Runtime: 55 ms - beats 73.91 % of csharp submissions.
        Memory Usage: 41.4 MB - beats 97.77 % of csharp submissions.

         */
        static void Main(string[] args)
        {           
            Console.WriteLine(new Solution().LengthOfLongestSubstring("aab")); //2
            Console.WriteLine(new Solution().LengthOfLongestSubstring("dvdf")); //3
            Console.WriteLine(new Solution().LengthOfLongestSubstring("fffdgrhytuydugjghofuhvkjh")); //8
        }


        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
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
                int lastCheckedIndex = 0;

                char[] value = s.ToCharArray();

                for (int i = 1; i < value.Length; i++)
                {
                    count = i;
                    substringLength = count - lastCheckedIndex;
                    breakWhile = false;
                    cycleCompleted = true;

                    while (count < value.Length)
                    {

                        for (int j = count - 1; j >= lastCheckedIndex; j--)
                        {
                            if (value[count] == value[j])
                            {
                                lastCheckedIndex = j + 1;
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
        }
    }
}
