using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP
{
    public class CoinChange
    {
        public int NoOfWays(int[] availableCoins, int sum)
        {
            return Count(availableCoins, sum);
        }

        private int Count(int[] availableCoins, int sum)
        {
            int[,] table = new int[availableCoins.Length + 1 , sum + 1];

            for (int i = 0; i <= availableCoins.Length; i++) table[i,0] = 1;

            for (int i = 1 ; i <= sum; i++) table[0, i] = 0;

            for (int i = 1; i <= availableCoins.Length; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (availableCoins[i - 1] <= j)
                        table[i, j] = table[i - 1, j] + table[i, j - availableCoins[i - 1]];
                    else
                        table[i, j] = table[i - 1, j];
                }
            }

            Helper.DisplayTwoDimensionalArray(table);

            return table[availableCoins.Length, sum];

        }
    }
}
