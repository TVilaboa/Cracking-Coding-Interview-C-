using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class Implementation
    {
        public static int[] GradingStudents(int[] grades)
        {
            for (var index = 0; index < grades.Length; index++)
            {
                var grade = grades[index];
                if (grade > 37)
                {
                    if ((grade + 1) % 5 == 0)
                    {
                        grades[index] = grade + 1;
                    }
                    else if ((grade + 2) % 5 == 0)
                    {
                        grades[index] = grade + 2;
                    }
                }
            }

            return grades;
        }

        public static int[] CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var applesInRange = 0;
            var orangesInRange = 0;
            foreach (var apple in apples)
            {
                if(apple+a >= s && apple + a <= t)applesInRange += 1;
            }
            foreach (var orange in oranges)
            {
                if (orange + b >= s && orange + b <= t) orangesInRange += 1;
            }

            Console.WriteLine(applesInRange);
            Console.WriteLine(orangesInRange);
            return new[] {applesInRange, orangesInRange};
        }

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            //If x1+z*v1-x2-z*v2=0, yes, else, no
            //z=(x2-x1)/(v1-v2)
            if (v1 == v2 && x1 != x2)
                return "NO";
            var stepsNeeded = Decimal.Divide((x2-x1),(v1-v2));
            if(stepsNeeded >= 0 && stepsNeeded % 1 == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }

       public static int GetTotalX(int[] a, int[] b)
       {
           var counter = 0;
            foreach (var i in Enumerable.Range(a.Max(),b.Min()))
            {

               if(a.All(aNumber => i%aNumber == 0) && b.All(bNumber => bNumber%i == 0))
                counter += 1;
            }

           return counter;
       }

        public static int[] BreakingRecords(int[] scores)
        {
            int max = scores[0];
             int min = scores[0];
            int counterMax = 0;
            int counterMin = 0;
            foreach (var score in scores)
            {
                if (score > max)
                {
                    max = score;
                    counterMax += 1;
                }else if (score < min)
                {
                    min = score;
                    counterMin += 1;
                }
            }

            return new[] {counterMax, counterMin};
        }
    }
}