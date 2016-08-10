using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LongestPalindrome s = new LongestPalindrome();
            s.FindLongestPalindrome("dabccba");
            Console.Read();
        }
    }
}
