using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class MaxSubArray
    {
        public int FindMaxSubArraySum(int[] array)
        {
            int max = array[0];
            int sum = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                max = Math.Max(array[i] + max, array[i]);
                sum = Math.Max(sum, max);
            }

            return sum;
        }
    }
}
