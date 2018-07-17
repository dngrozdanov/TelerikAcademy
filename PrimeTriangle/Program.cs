using System;
using System.Collections.Generic;

namespace PrimeTriangleWIP
{
    class Program
    {
        static void Main()
        {
            int Number = Convert.ToInt32(Console.ReadLine());
            List<int> PrimeNumbers = new List<int>();
            for (int i = 1; i <= Number; i++)
            {
                if (IsPrime(i))
                {
                    PrimeNumbers.Add(1);
                }
                else
                {
                    PrimeNumbers.Add(0);
                    continue;
                }
                Console.WriteLine(string.Join("", PrimeNumbers));
            }
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return true;
            if (number < 2) return false;
            if (number % 2 == 0) return number == 2;
            var root = (int)Math.Sqrt(number);
            for (var i = 3; i <= root; i += 2)
                if (number % i == 0) return false;
            return true;
        }
    }
}