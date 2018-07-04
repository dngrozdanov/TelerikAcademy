using System;
using System.Numerics;

namespace CalculateAgain
{
    class Program
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            //if (N < K || N < 1 || N > 100) return;
            //if (K > N || K < 1 || K > 100) return;
            var Factorials = CalculateFactorial(new BigInteger[] { N, K });
            Console.WriteLine(Factorials[0] / Factorials[1]);
        }

        static BigInteger[] CalculateFactorial(BigInteger[] NK)
        {
            BigInteger firstFactorial = 1;
            BigInteger secondFactorial = 1;
            for (int i = 1; i <= BigInteger.Max(NK[0], NK[1]); i++)
            {
                if (i <= NK[0])
                {
                    firstFactorial = firstFactorial * i;
                }
                if (i <= NK[1])
                {
                    secondFactorial = secondFactorial * i;
                }
            }
            return new BigInteger[] { firstFactorial, secondFactorial };
        }
    }
}
