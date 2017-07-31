using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace Codefights.Arcade.CodeArcade.IntroGates
{
    public class MetroCardTests
    {
        int[] metroCard(int lastNumberOfDays)
        {
            var daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var list = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                if (daysOfMonths[i] == lastNumberOfDays)
                {
                    list.Add
                        (i != 11
                            ? daysOfMonths[i + 1]
                            : daysOfMonths[0]);
                }
            }

            return list.Distinct().ToArray();
        }
        [Theory]
        [MemberData(nameof(TestData))]
        public void gwt(int lastNumberOfDays, int[] expected)
        {
            var actual = this.metroCard(lastNumberOfDays);

            Assert.Equal(expected, actual);
        }

        private static object[][] TestData()
        {
            return new[]
                   {
                       new object[]
                       {
                           30, new[]{31}
                       },
                       new object[]
                       {
                           31,new[]{ 28, 30, 31 }
                       },
                   };
        }
    }
}