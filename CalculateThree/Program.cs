using System;
using System.Numerics;

namespace CalculateThree
{
    class Program
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            var Factorials = CalculateFactorial(new BigInteger[] { N, K });
            Console.WriteLine(Calculate(Factorials[0], Factorials[1], N, K));
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

        static BigInteger CalculateSingleFactorial(BigInteger Factorial)
        {
            BigInteger singleFactorial = 1;
            for (int i = 1; i <= Factorial; i++)
            {
                singleFactorial = singleFactorial * i;
            }
            return singleFactorial;
        }

        static string Calculate(BigInteger NFactorial, BigInteger kFactorial, BigInteger N, BigInteger k)
        {
            BigInteger Sum;
            // Formula
            Sum = NFactorial / (kFactorial * CalculateSingleFactorial(N - k));
            return Sum.ToString();
        }
    }
}
