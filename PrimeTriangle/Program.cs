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
            for (int i = 0; i < Number; i++)
            {
                if (IsPrime(i) || i == 1 || i == 2)
                {
                    PrimeNumbers.Add(i);
                }
            }

            for (int j = 0; j < PrimeNumbers.Count; j++)
            {
                for (int x = 1; x <= PrimeNumbers[j]; x++)
                {
                    if (IsPrime(x) || x == 1 || x == 2)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return number == 2;
            var root = (int)Math.Sqrt(number);
            for (var i = 3; i <= root; i += 2)
                if (number % i == 0) return false;
            return true;
        }
    }
}