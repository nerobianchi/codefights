using System;
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

        [Theory]
        [MemberData(nameof(TestData3))]
        public void gwtt(int a, int b, int c,bool expected)
        {
            var actual = arithmeticExpression(a, b, c);
            
            Assert.Equal(expected, actual);
        }

        bool arithmeticExpression(int a, int b, int c)
        {
            if (a + b == c) return true;
            if (a - b == c) return true;
            if (a * b == c) return true;
            if ((float)a / b == c ) return true;
            return false;
        }
        
        private static object[][] TestData3()
        {
            return new[]
            {
                new object[]
                {
                    8,3,2,false
                },
            };
        }
        
        
        
        
        [Theory]
        [MemberData(nameof(TestData2))]
        public void gwtt(int a, int b,bool expected)
        {
            var actual = tennisSet(a, b);
            
            Assert.Equal(expected, actual);
        }
        private static object[][] TestData2()
        {
            return new[]
            {
                new object[]
                {
                    7,2,false
                },new object[]
                {
                    7,6,true
                },new object[]
                {
                    7,5,true
                },
            };
        }
        
        
//            if(score1 == 5 || score2 == 5)
//            {
//                return Math.Abs(score1-score2) == 2 ;
//            }

//            if(max > 6 || min > 6){
//                return  Math.Abs(max-min) == 2    ;
//            }
//            return Math.Abs(max-min) >= 2;   

        
        
        bool tennisSet(int score1, int score2) {
            
            int max = score1;
            int min = score2;
            if(score1 < score2)
            {
                max=score2;
                min = score1;
            }
            
            if (max==min)
            {
                return false;
            }
            if (max == 6 && min < 5)
            {
                return true;
            }
            if (max == 7 && (min == 5 || min == 6))
                return true;
            
            return false;

        }

    }
}