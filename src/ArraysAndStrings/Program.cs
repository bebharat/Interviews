﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var threeSum = new _3Sum();

            int[] arr = { -1, 0, 1, 2, -1, -4 };
            threeSum.find3SumToZero(arr);
            Console.Read();
        }
    }
}
