using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Katas._24._03._2022
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            int result = 0;
            if (string.IsNullOrEmpty(str)) return result;
            List<char> charsRaw = str.ToLower().ToCharArray().ToList();
            charsRaw.RemoveAll(c => c.Equals(' '));
            List<char> charsUnique = charsRaw.Distinct().ToList();
            foreach (var eachCharUnique in charsUnique)
            {
                var duplicatesCount = charsRaw.RemoveAll(c => c.Equals(eachCharUnique));
                if (duplicatesCount > 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}