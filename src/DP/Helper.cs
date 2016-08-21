using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP
{
    public static class Helper
    {
        public static void DisplayTwoDimensionalArray(int[,] obj)
        {
            for (int i = 0; i < obj.GetLength(0); i++)
            {
                for (int j = 0; j < obj.GetLength(1); j++)
                    Console.Write(" " + obj[i,j]);
                Console.WriteLine();
            }
        }
    }
}
