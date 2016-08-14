using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 4,1,1,4,2,1 };

            MaximumSumSubsequence obj = new MaximumSumSubsequence();
            obj.MSS_Non_Adjacent(arr1);

            Console.ReadLine();
        }
    }
}
