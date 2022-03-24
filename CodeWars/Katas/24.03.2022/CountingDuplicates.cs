using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Katas._24._03._2022
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
        }
    }
}