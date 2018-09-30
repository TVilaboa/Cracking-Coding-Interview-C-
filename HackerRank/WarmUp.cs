using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

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

        public static float[] PlusMinus(int[] arr)
        {
            var positives = 0;
            var negatives = 0;
            var zeros = 0;

            foreach (var i in arr)
            {
                if (i > 0) positives += 1;
                else if (i < 0)
                    negatives += 1;
                else
                    zeros += 1;
            }
            Console.WriteLine((float)positives / arr.Length);
            Console.WriteLine((float)negatives / arr.Length);
            Console.WriteLine((float)zeros / arr.Length);
            return new float[] {(float) positives / arr.Length, (float)negatives / arr.Length , (float)zeros / arr.Length };

        }

        public static string[] Staircase(int size)
        {
            var staircase = new string[size];
            for (int i = 1; i <= size; i++)
            {
                var step = new String(' ', size - i) + new String('#',i);
                staircase[i - 1] = step;
                Console.WriteLine(step);
            }

           
            return staircase;

        }

        public static long[] MiniMaxSum(long[] numbers)
        {
            var results = new long[2];
            var sortedNumbers = numbers.ToList();
            sortedNumbers.Sort();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i >= 0 && i < numbers.Length -1 )
                results[0] += sortedNumbers[i];
                if (i >= 1 )
                    results[1] += sortedNumbers[i];
            }
            Console.WriteLine(results[0] + " " + results[1]);
            return results;
        }

        public static int BirthdayCakeCandles(int[] candleHeights)
        {
            var max = 0;
            var counter = 0;
            foreach (var candleHeight in candleHeights)
            {
                if (candleHeight > max)
                {
                    max = candleHeight;
                    counter = 0;
                }

                if (candleHeight == max)
                {
                    counter += 1;
                }
            }

            return counter;
        }

        public static string TimeConversion(string time)
        {
           return DateTime.ParseExact(
                time,
                "h:mm:sstt",
                CultureInfo.InvariantCulture).ToString("HH:mm:ss");
        }
    }
}
