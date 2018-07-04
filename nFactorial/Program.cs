using System;
using System.Numerics;

namespace nFactorial
{
    class Program
    {
        static void Main()
        {
            BigInteger Factorial = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(Factorial));
        }

        static BigInteger CalculateFactorial(BigInteger Factorial)
        {
            BigInteger singleFactorial = 1;
            for (int i = 1; i <= Factorial; i++)
            {
                singleFactorial = singleFactorial * i;
            }
            return singleFactorial;
        }
    }
}