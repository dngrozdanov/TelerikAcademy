using System;
using System.Collections.Generic;
using System.Linq;

namespace BiggestPrimeNumber
{
    internal static class Program
    {
        private static void Main()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number < 2 || number > 10000000) return;
            if (number == 2)
            {
                Console.Write("2");
                return;
            }
            var PrimeNumbers = new List<int>(2);
            for (var i = number; i >= 1; i--)
            {
                if (PrimeNumbers.Count > 0) break;
                if (IsPrime(i))
                    PrimeNumbers.Add(i);
            }
            Console.WriteLine(PrimeNumbers.First());
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return number == 2;
            var root = (int) Math.Sqrt(number);
            for (var i = 3; i <= root; i += 2)
                if (number % i == 0) return false;
            return true;
        }
    }
}