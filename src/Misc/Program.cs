using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Permutations s = new Permutations();
            //s.PrintPermutations("abc");

            var obj = new SpacePermutation();
            obj.SpacePermute("ABC");

            Console.ReadLine();
        }
    }
}
