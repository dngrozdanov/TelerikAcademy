using System;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (b < a)
                Console.WriteLine("{0} {1}", b, a);
            else if (a <= b)
                Console.WriteLine("{0} {1}", a, b);
        }
    }
}