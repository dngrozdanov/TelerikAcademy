using System;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fact2N = 1;
            BigInteger factNPlus1 = 1;
            BigInteger factN = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int k = 1; k <= 2 * n; k++)
            {
                fact2N *= k;
            }
            for (int j = 1; j <= n + 1; j++)
            {
                factNPlus1 *= j;
            }
            Console.WriteLine(fact2N / (factNPlus1 * factN));
        }
    }
}