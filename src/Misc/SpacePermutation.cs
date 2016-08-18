using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misc
{
    /*
        Given a string you need to print all possible strings that can be made by placing spaces (zero or one) in between them.
        Input:  str[] = "ABC"
        Output: ABC || AB C || A BC || A B C
    */

    public class SpacePermutation
    {
        public void SpacePermute(string str)
        {
            SpacePermute("", str);
        }

        private void SpacePermute(string soFar, string src)
        {
            if (src == null || src == "")
                Console.WriteLine(soFar);
            else
            {
                SpacePermute(soFar + src[0].ToString(), src.Substring(1));

                if (src.Length > 1)
                    SpacePermute(soFar + src[0].ToString() + " ", src.Substring(1));
            }
        }
    }
}
