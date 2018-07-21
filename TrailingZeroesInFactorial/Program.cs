using System;
using System.Numerics;

namespace TrailingZeroesInFactorial
{
    class Startup
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 0;
            for (BigInteger i = 5; i <= n; i *= 5)
            {
                result = result + (n / i);
            }
            Console.WriteLine($"{result}");
        }
    }
}