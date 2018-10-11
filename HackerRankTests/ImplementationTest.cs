using HackerRank;
using Xunit;

namespace HackerRankTests
{
    public class ImplementationTest
    {
        //Sample Input 0

        //4
        //73
        //67
        //38
        //33
        //Sample Output 0

        //75
        //67
        //40
        //33
        [Fact]
        public void GradingStudents()
        {
            Assert.Equal(new int[] { 75, 67, 40, 33 }, Implementation.GradingStudents(new int[] { 73, 67, 38, 33 }));

        }

        //Sample Input 0

        //7 11
        //5 15
        //3 2
        //-2 2 1
        //5 -6
        //Sample Output 0

        //1
        //1
        [Fact]
        public void CountApplesAndOranges()
        {
            Assert.Equal(new int[]{1,1},Implementation.CountApplesAndOranges(7,11,5,15,new []{-2,2,1},new []{5,-6}));
        }

        //Sample Input 0

        //0 3 4 2
        //Sample Output 0

        //YES
     
        //    Sample Input 1

        //0 2 5 3
        //Sample Output 1

        //NO
        //Sample Input 2
        //21 6 47 3
        [Theory]
        [InlineData("NO",0, 2, 5, 3)]
        [InlineData("NO",21, 6, 47, 3)]
        [InlineData("YES", 0, 3, 4, 2)]
     
       public void Kangaroo(string expected,int x1, int v1, int x2, int v2)
        {
            Assert.Equal(expected, Implementation.Kangaroo(x1,v1,x2,v2));

        }

        //Sample Input

        //2 3
        //2 4
        //16 32 96
        //Sample Output

        //3

        [Theory]
        [InlineData(3,new[]{2,4},new[]{16,32,96})]
       

        public void GetTotalX(int expected, int[] a,int[] b)
        {
            Assert.Equal(expected, Implementation.GetTotalX(a,b));

        }

        //Sample Input 1

        //10
        //3 4 21 36 10 28 35 5 24 42
        //Sample Output 1

        //4 0
        [Theory]
        [InlineData(new[] { 4,0}, new[] { 3,4,21,36,10,28,35,5,24,42 })]
        public void BreakingRecords(int[] expected, int[] scores)
        {
            Assert.Equal(expected, Implementation.BreakingRecords(scores));

        }

    }
}