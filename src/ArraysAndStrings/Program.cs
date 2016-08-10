using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            int[] arr = { -1, 0, 1, 2, -1, -4 };

            //var threeSum = new _3Sum();
            //threeSum.find3SumToZero(arr);

            var maxSubarray = new MaxSubArray();
            var max = maxSubarray.FindMaxSubArraySum(arr);
            Console.WriteLine(max);


            Console.Read();
        }
    }
}
