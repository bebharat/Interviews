using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misc
{
    public class Permutations
    {
        public void PrintPermutations(string src)
        {
            PrintPermutations("", src);
            Console.ReadLine();
        }

        private void PrintPermutations(string soFar, string src)
        {
            if (src == null || src == "")
                Console.WriteLine(soFar);

            else
            {
                for(int i = 0; i < src.Length; i++)
                {
                    var next = soFar + src[i];
                    var remaining = src.Substring(0, i) + src.Substring(i + 1);
                    PrintPermutations(next, remaining); 
                }
            }
        }
    }
}
