using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class ClosestPair
    {
        public void FindClosestPair(int[] firstArray, int[] secondArray, int key)
        {
            if (firstArray.Length == 0 || secondArray.Length == 0)
                return;

            Console.WriteLine("First Array : " + string.Join(" ", firstArray));
            Console.WriteLine("Second Array : " + string.Join(" ", secondArray));

            int left = 0;
            int right = secondArray.Length - 1;
            int diff = int.MaxValue;

            int[] solution = new int[2];

            while(left < firstArray.Length && right >= 0)
            {
                //Console.WriteLine("    Value of left = " + left);
                //Console.WriteLine("    Value of right = " + right);

                int sum = firstArray[left] + secondArray[right];

                if (Math.Abs(sum - key) < diff)
                {
                    //Console.WriteLine("    Old diff = " + diff);
                    diff = Math.Abs(sum - key);
                    //Console.WriteLine("    New diff = " + diff);
                    solution[0] = firstArray[left];
                    solution[1] = secondArray[right];
                }

                if (sum == key)
                {
                    Console.WriteLine("The closest pair is " + firstArray[left] + " and " + secondArray[right]);
                    return;
                }
                else if ( sum < key) left++;
                else right--;                
            }

             Console.WriteLine("The closest pair is " + solution[0] + " and " + solution[1]);
        }
    }
}
