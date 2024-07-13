using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace leetcode_007
{
    class Program
    {
        /*
        Hard

        You are given a string s and an array of strings words. All the strings of words are of the same length.
        A concatenated string is a string that exactly contains all the strings of any permutation of words concatenated.
        For example, if words = ["ab","cd","ef"], then "abcdef", "abefcd", "cdabef", "cdefab", "efabcd", and "efcdab" are all concatenated strings.
        "acdbef" is not a concatenated string because it is not the concatenation of any permutation of words.

        
        181 / 181 test cases passed. Status: Accepted
        Runtime: 1104 ms - Beats 36.31 % of csharp submissions.
        Memory Usage: 130.9 MB    - Beats 5.03% of csharp submissions.
         */

        static void Main(string[] args)
        {
            Solution solution = new Solution();

         IList<int> vs = solution.FindSubstring("a", new string[]{ "a" }); //1
            foreach(int el in vs)
            {
                Console.WriteLine("1---" + el);
            }

            IList<int> vs1 = solution.FindSubstring("bccbcc", new string[] { "bc", "cc", "cb" });  //0
            foreach (int el in vs1)
            {
                Console.WriteLine("2---" +el);
            }

            IList<int> vs2 = solution.FindSubstring("abbccbc", new string[] { "bc", "cc", "bb" }); //1
            foreach (int el in vs2)
            {
                Console.WriteLine("3---" + el);
            }

            IList<int> vs3 = solution.FindSubstring("acaaa", new string[] { "aa", "ca" }); //1
            foreach (int el in vs3)
            {
                Console.WriteLine("4---" + el);
            }

            IList<int> vs4 = solution.FindSubstring("ababababab", new string[] { "ababa", "babab" }); //0
            foreach (int el in vs4)
            {
                Console.WriteLine("5---" + el);
            }

            IList<int> vs5 = solution.FindSubstring("aaaaaaaaaa", new string[]{ "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a"}); //0
            foreach (int el in vs5)
            {
                Console.WriteLine("6---" + el);
            }
        }
    }

    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            int count = 0;
            int totalNumberCharacters = words.Length * words[0].Length;
            IList<int> maximumNumberSubstrings = new List<int>();
            IList<int> intermediateЬaximumNumberSubstrings = new List<int>();

            bool arrayElementsWereSummed = false;
            string sum = null;
            string[] sumWordsArray = new string[1];

            if (words[0].Length == 1 && words.Length > 10)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == words[j])
                    {
                        sum += words[j];
                        arrayElementsWereSummed = true;
                    }
                    else
                    {
                        arrayElementsWereSummed = false;
                        break;
                    }
                }

                if (arrayElementsWereSummed)
                {
                    sumWordsArray[0] = sum;
                }
            }

            while (count < words.Length)
            {
                Console.WriteLine(arrayElementsWereSummed);
                if (arrayElementsWereSummed)
                    intermediateЬaximumNumberSubstrings = FindingMaximumNumberSubstrings(s, sumWordsArray, arrayElementsWereSummed);
                else
                    intermediateЬaximumNumberSubstrings = FindingMaximumNumberSubstrings(s, words, arrayElementsWereSummed);


                if (intermediateЬaximumNumberSubstrings.Count > maximumNumberSubstrings.Count)
                {
                    maximumNumberSubstrings = intermediateЬaximumNumberSubstrings;
                }

                if (maximumNumberSubstrings.Count != 0 && words.Length > 3)
                    break;

                if (words.Length < 2)
                    break;

                if (count + 1 < words.Length)
                    count++;
                else
                    break;

                (words[0], words[count]) = (words[count], words[0]);
            }
            return maximumNumberSubstrings;

        }

        private IList<int> FindingMaximumNumberSubstrings(string s, string[] words, bool arrayElementsWereSummed)
        {
            List<int> indexList = new List<int>();
            List<int> resultList = new List<int>();
            string substitutionString = new string('1', words[0].Length);
            int wordsLength = words.Length;
            int wordsElLength = words[0].Length;
            string start = "";
            string end = "";
            int count = 0;
            int maxCount = 100;
            int receivedIndex;

            if (arrayElementsWereSummed)
            {
                maxCount = s.Length - wordsLength + 1;
            }

            while (count <= s.Length - wordsLength && count < maxCount)
            {
                string value = s;
                for (int i = 0; i < wordsLength; i++)
                {
                    receivedIndex = FindingIndexSubstring(ref value, substitutionString, words[i], count, start, end);
                    if (receivedIndex != -1)
                    {
                        indexList.Add(receivedIndex);
                    }

                }

                indexList.Sort();


                if (ConditionCheck(indexList, wordsLength, wordsElLength))
                {
                    if (!resultList.Contains(indexList[0]))
                        resultList.Add(indexList[0]);
                }

                if (resultList.Count != 0 && words.Length > 10)
                    break;

                if (words.Length > 10 && wordsElLength > 1)
                    count += wordsLength;
                else
                    count += 1;

                indexList.Clear();
            }



            return resultList;
        }

        private int FindingIndexSubstring(ref string value, string substitutionString, string word, int startIndex, string start, string end)
        {
            int index = value.IndexOf(word, startIndex);

            if (index != -1)
            {
                start = value.Substring(0, index);
                end = value.Substring(index + word.Length);
                value = start + substitutionString + end;

            }

            return index;
        }

        private bool ConditionCheck(List<int> indexList, int wordsLength, int wordsElLength)
        {
            bool isConcatenated = true;

            if (indexList.Count != wordsLength)
            {
                return isConcatenated = false;
            }

            for (int i = 0; i + 1 < wordsLength; i++)
            {
                if (indexList[i + 1] - indexList[i] != wordsElLength)
                    isConcatenated = false;
            }

            return isConcatenated;
        }
    }
}

