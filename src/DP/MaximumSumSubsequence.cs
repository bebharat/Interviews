using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP
{
    public class MaximumSumSubsequence
    {
        public void MSS_Non_Adjacent(int[] arr)
        {
            int inclusive = arr[0];
            int exclusive = 0;

            for(int i = 1; i < arr.Length; i++)
            {
                int temp = inclusive;
                inclusive = Math.Max(inclusive, exclusive + arr[i]);
                exclusive = temp;
            }

            Console.WriteLine("The answer is " + inclusive);
        }
    }
}
