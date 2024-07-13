using System;

namespace leetcode_004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a function to find the longest common prefix string amongst an array of strings.
            If there is no common prefix, return an empty string "".

            126 / 126 test cases passed. Status: Accepted
            Runtime: 63 ms - beats 84.66 % of csharp submissions.
            Memory Usage: 42 MB -  beats 80.93 % of csharp submissions.
             */
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[]{ "c" }));
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int prefixLength = 0;            
            int stringCharacterIndex = 0;
            int arrayIndex = 0;
            while (true)
            {                 
                while (arrayIndex < strs.Length && stringCharacterIndex < strs[0].Length && stringCharacterIndex < strs[arrayIndex].Length)
                {
                    if (strs[0][stringCharacterIndex] == strs[arrayIndex][stringCharacterIndex])
                        arrayIndex++;
                    else
                        break;                                          
                }

                if (arrayIndex == strs.Length)
                    prefixLength++;
                else
                    break;

                arrayIndex = 0;
                stringCharacterIndex++;
            }

            return strs[0].Substring(0, prefixLength);

            
        }
    }
}
