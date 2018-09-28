using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class WarmUp
    {

       
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var scores = new List<int>(2){0,0};
            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] > b[i]) scores[0] += 1;
                else if (a[i] < b[i]) scores[1] += 1;
            }

            return scores;
        }

        public static long AVeryBigSum(long[] ar)
        {
            return ar.Sum();

        }

        public static int DiagonalDifference(int[][] arr)
        {
            var firstDiagonal = 0;
            var secondDiagonal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                firstDiagonal += arr[i][i];
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                secondDiagonal += arr[i][arr.Length-1-i];
            }

            return Math.Abs(firstDiagonal - secondDiagonal);

        }
    }
}
