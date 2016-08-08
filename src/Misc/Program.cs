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
            PrintAllSubsets s = new PrintAllSubsets();
            s.PrintSubsets_recursiveMethod("abc");
        }
    }
}
