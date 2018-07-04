using System;
using System.Linq;

namespace GCD
{
    internal static class Program
    {
        internal static void Main()
        {
            var Digits = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            if (Digits == null) return;
            Console.WriteLine(GCD(Digits[0], Digits[1]));
        }

        private static int GCD(int a, int b)
        {
            var gcd = 0;
            if (a > b)
            {
                var t = b;
                b = a;
                a = t;
            }
            while (b != 0)
            {
                gcd = a % b;
                a = b;
                if (gcd == 0)
                {
                    gcd = b;
                    break;
                }
                b = gcd;
            }
            return gcd;
        }
    }
}