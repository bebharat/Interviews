using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class _3Sum
    {
        public bool find3SumToZero(int[] array)
        {
            // nlog(n)
            Array.Sort(array);

            // n^2 solution
            // todo : optimize to nlon(n) using binary search
            for(int i = 0; i < array.Length - 1; i++)
            {
                var current = array[i];

                var low = i + 1;
                var high = array.Length - 1;

                while( low < high)
                {
                    var sum = current + array[low] + array[high];

                    if (sum == 0)
                    {
                        Console.WriteLine("{0}, {1}, {2}", current, array[low], array[high] );
                        return true;
                    }          

                    else if (sum > 0)
                        high--;
                    else low++;
                }
            }

            return false;

        }
    }
}
