using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank;
using Newtonsoft.Json;
using Xunit;

namespace HackerRankTests
{
    public class WarmUpTest
    {
        //Sample Input 1

        //17 28 30
        //99 16 8
        //Sample Output 1

        //2 1
        [Fact]
        public void CompareTriplets()
        {
            var input1 = new List<int> {17, 28, 30};
            var input2 = new List<int> {99, 16, 8};
            var expectedOutput = new List<int>(){2,1};

            var output = WarmUp.CompareTriplets(input1,input2);
            Assert.Equal(expectedOutput,output);
        }

        //Sample Input

        //5
        //1000000001 1000000002 1000000003 1000000004 1000000005
        //Output

        //5000000015
        [Fact]
        public void AVeryBigSum()
        {
            var input = new long[5]{ 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Assert.Equal(5000000015,WarmUp.AVeryBigSum(input));
        }

        //Sample Input

        //3
        //11 2 4
        //4 5 6
        //10 8 -12
        //Sample Output

        //15
        [Fact]
        public void DiagonalDifference()
        {
            var firstRow = new int[3] { 11, 2, 4 };
            var secondRow = new int[3] {4, 5, 6};
            var thirdRow = new int[3] {10, 8, -12};
            var input = new int[3][]{firstRow,secondRow,thirdRow};

            Assert.Equal(15,WarmUp.DiagonalDifference(input));

        }

    }
}
