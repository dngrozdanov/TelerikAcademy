using System;
using System.Collections.Generic;
using System.Linq;

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
                if (IsPrime(i))
                {
                    PrimeNumbers.Insert(0, i);
                }
            }
            for (int i = 1; i < PrimeNumbers.First(); i++)
            {
                if (IsPrime(i) || i == 2)
                    Console.Write(1);
                else
                    Console.Write(0);
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
