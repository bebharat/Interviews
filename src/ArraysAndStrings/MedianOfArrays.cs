using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class MedianOfArrays
    {
        public void FindMedian(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length == secondArr.Length)
                Console.WriteLine(" The median of the given arrays is  "+FindMedian(firstArr, secondArr, firstArr.Length));
        }

        private int FindMedian(int[] firstArr, int[] secondArr, int length)
        {
            //Console.WriteLine("First Array : " + string.Join(" ",firstArr) + " of length " + length);
            //Console.WriteLine("Second Array : " + string.Join(" ", secondArr) + " of length " + length);

            if (length == 1)
                return (firstArr[0] + secondArr[0]) / 2;

            if (length == 2)
                return (Math.Max(firstArr[0], secondArr[0]) + Math.Min(firstArr[1], secondArr[1])) / 2;

            int m1 = Median(firstArr, length);
            int m2 = Median(secondArr, length);

            //Console.WriteLine("Median for the first array = " + m1);
            //Console.WriteLine("Median for the second array = " + m2);

            int mid = length / 2;

            if (m1 < m2)
            {
                if (length % 2 == 0)
                {
                    FindMedian(firstArr.Skip(mid - 1).ToArray(), secondArr.Take(mid + 1).ToArray(),length - (length/2) + 1);
                }

                return FindMedian(firstArr.Skip(mid).ToArray(), secondArr.Take(mid).ToArray(), length - (length / 2));
            }

            if (length % 2 == 0)
            {
                return FindMedian(secondArr.Skip(mid - 1).ToArray(), firstArr.Take(mid + 1).ToArray(), length - (length / 2) + 1);
            }

            return FindMedian(secondArr.Skip(mid).ToArray(), firstArr.Take(mid + 1).ToArray(), length - (length / 2));
        }

        private int Median(int[] arr, int length)
        {
            int mid = length / 2;
            if (length % 2 == 0)
            {
                int firstMedian = arr[mid];
                int secondMedian = arr[mid - 1];

                //Console.WriteLine("        Median   : " + (firstMedian + secondMedian) / 2 + " for received Array = " + arr.ToString());

                return (firstMedian + secondMedian) / 2;
            }

            //Console.WriteLine("        Median   : " + arr[mid] + " for received Array = " + arr.ToString());

            return arr[mid];
        }
    }
}
