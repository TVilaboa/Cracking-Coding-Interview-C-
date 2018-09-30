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

        //Sample Input

        //6
        //-4 3 -9 0 4 1         
        //Sample Output

        //0.500000
        //0.333333
        //0.166667
        [Fact]
        public void PlusMinus()
        {
            
            var input = new int[6] { -4, 3, -9, 0, 4, 1 };

            Assert.Equal(new float[]{0.5f,(float)1/3, (float)1 /6}, WarmUp.PlusMinus(input));

        }

        //        Sample Input

        //        6 
        //        Sample Output

        //        #
        //       ##
        //      ###
        //     ####
        //    #####
        //   ######
        [Fact]
        public void Staircase()
        {
            var line1 = "     #";
            var line2 = "    ##";
            var line3 = "   ###";
            var line4 = "  ####";
            var line5 = " #####";
            var line6 = "######";

            Assert.Equal(new string[]{line1,line2,line3,line4,line5,line6}, WarmUp.Staircase(6));

        }

        //Sample Input

        //1 2 3 4 5
        //Sample Output

        //10 14
        [Fact]
        public void MiniMaxSum()
        {
           Assert.Equal(new long[] {10,14}, WarmUp.MiniMaxSum(new long[] { 1,2,3,4,5 }));

        }

        //Sample Input 0

        //4
        //3 2 1 3
        //Sample Output 0

        //2

        [Fact]
        public void BirthdayCackeCandles()
        {
            Assert.Equal(2, WarmUp.BirthdayCakeCandles(new int[] { 3, 2, 1, 3 }));

        }

        //Sample Input 0

        //07:05:45PM
        //    Sample Output 0

        //19:05:45
        [Fact]
        public void TimeConversion()
        {
            Assert.Equal("19:05:45", WarmUp.TimeConversion("07:05:45PM"));

        }

    }
}
