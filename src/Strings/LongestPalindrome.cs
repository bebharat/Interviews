using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strings
{
    public class LongestPalindrome
    {
        //Finding Longest Palindrome Substring : dabcba

        public string FindLongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
                return null;

            if (s.Length == 1)
                return s;

            var longestPalindrome = s.Substring(0, 1);

            for(int i = 1; i < s.Length - 1; i++)
            {
                // Find longest string with i in the middle
                var result = helperForPalindrome(s, i, i);

                if (result.Length > longestPalindrome.Length)
                    longestPalindrome = result;

                // Find longest string with i, i+1 in the middle
                if (s[i] == s[i + 1])
                {
                    result = helperForPalindrome(s, i, i + 1);

                    if (result.Length > longestPalindrome.Length)
                        longestPalindrome = result;
                }
            }

            Console.WriteLine(longestPalindrome);
            return s;
        }

        private string helperForPalindrome(string s, int begin, int end)
        {
            while (begin >= 0 && end <= (s.Length - 1) && s[begin] == s[end])
            {
                begin--;
                end++;
            }

            var startIndex = begin + 1;
            var length = end - startIndex;
            return s.Substring(startIndex, length);
        }
    }
}
