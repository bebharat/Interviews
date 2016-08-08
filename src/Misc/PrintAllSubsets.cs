using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misc
{
    public class PrintAllSubsets
    {
        public void PrintSubsets_booleanMethod(int[] input)
        {
            int totalSubsetCount = (1 << input.Length) - 1;
            int tmp;
            while (totalSubsetCount != 0)
            {
                tmp = totalSubsetCount;
                for (int i = 0; i < input.Length; i++)
                {
                    if ((tmp & 1) != 0)
                        Console.Write(input[i] + " ");
                    tmp >>= 1;
                }
                Console.WriteLine();
                totalSubsetCount--;
            }
            Console.Read();
        }

        public void PrintSubsets_recursiveMethod(string src)
        {
            PrintSubsets("", src);
            Console.ReadLine();
        }

        private void PrintSubsets(string soFar, string src)
        {
            if (src == null || src == "")
                Console.WriteLine(soFar);

            else 
            {
                PrintSubsets(soFar + src[0], src.Substring(1));
                PrintSubsets(soFar, src.Substring(1));
            }
        }
    }
}