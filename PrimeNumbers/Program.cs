using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    internal static class Program
    {
        private static void Main()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 1024) return;
            if (number == 2)
            {
                Console.Write("1 2");
                return;
            }
            var PrimeNumbers = new List<int>();
            for (var i = 0; i < number; i++)
                if (IsPrime(i))
                    PrimeNumbers.Add(i);
            Console.Write("1");
            foreach (var Prime in PrimeNumbers)
            {
                Console.Write(" ");
                Console.Write(Prime);
            }
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