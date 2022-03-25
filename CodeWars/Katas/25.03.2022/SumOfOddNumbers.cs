using System;

namespace CodeWars.Katas._25._03._2022
{
    public class SumOfOddNumbers
    {
        public static long RowSumOddNumbers(long n)
        {
            long firstNumberInRow = 1;
            for (long row = 1; row <= n; row++)
            {
                firstNumberInRow += 2 * (row - 1);
            }

            long sumInRow = 0;
            for (long column = 1; column <= n; column++)
            {
                sumInRow += firstNumberInRow + 2 * (column - 1);
            }

            return sumInRow;
        }
    }
}