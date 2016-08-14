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
            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //int[] arr2 = { 5, 3, 7, 2 };

            //var threeSum = new _3Sum();
            //threeSum.find3SumToZero(arr);

            //var maxSubarray = new MaxSubArray();
            //var max = maxSubarray.FindMaxSubArraySum(arr);
            //Console.WriteLine(max);

            //var ms = new MergeSort();
            //ms.Sort(arr2);

            int[] arr1 = { 1,2,8,9 }; 
            int[] arr2 = { 3,6,10,11 };

            MedianOfArrays obj = new MedianOfArrays();
            obj.FindMedian(arr1, arr2);

            Console.Read();
        }
    }
}
