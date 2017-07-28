using Xunit;

namespace Codefights.Arcade.CodeArcade.IntroGates
{
    public class PhoneCallTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void gwt(int min1, int min2_10, int min11, int s, int expected)
        {
            Sut sut = new Sut();
            var actual = sut.phoneCall(min1, min2_10, min11, s);

            Assert.Equal(expected, actual);
        }

        private static object[][] TestData()
        {
            return new[]
                   {
                       new object[]
                       {
                           3, 1, 2, 20, 14
                       },
                       new object[]
                       {
                           2, 2, 1, 2, 1
                       },
                       new object[]
                       {
                           10, 1, 2, 22, 11
                       }
                   };
        }
    }
}