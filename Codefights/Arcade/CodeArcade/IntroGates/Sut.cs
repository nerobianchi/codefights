using System;

namespace Codefights.Arcade.CodeArcade.IntroGates
{
    class Sut
    {
        int addTwoDigits(int n)
        {
            int total = 0;
            foreach (var s in n.ToString())
            {
                total += Int32.Parse(s.ToString());
            }
            return total;
        }
        int largestNumber(int n)
        {
            return (int)Math.Pow(10, n) - 1;
        }
        int candies(int n, int m)
        {
            return m - (int)Math.Floor((decimal)(m % n));
        }

        int maxMultiple(int divisor, int bound)
        {
            return bound - (int)Math.Floor((decimal)(bound % divisor));

        }
        int lateRide(int n)
        {
            var hour = Math.Floor((decimal)(n / 60));
            var min = n % 60;


            return (int)(Math.Floor(hour / 10) + (hour % 10) + Math.Floor((decimal)(min / 10)) + (min % 10));

        }
        public int phoneCall(int min1, int min2_10, int min11, int s)
        {
            if (s < min1)
            {
                return 0;
            }
            int remaining = s - min1;

            var total = 1;

            if (remaining > min2_10 * 9)
            {
                total += 9;
                remaining = remaining - 9 * min2_10;
            }
            else
            {
                int i = remaining / min2_10;
                return total + i;
            }

            int i1 = remaining / min11;
            total += i1;
            return total;
        }
    }
}