using System;
using System.Numerics;

namespace ReturnMoney
{
    internal static class Program
    {
        private static void Main()
        {
            var FirstLine = Console.ReadLine()?.Split(null);
            if (FirstLine?[0] == null || FirstLine[1] == null) return;
            if (FirstLine[0].Length > 1000 || FirstLine[1].Length > 1000) return;
            if (FirstLine[0].Length < 1 || FirstLine[1].Length < 1) return;
            try
            {
                var MoneyGiven = BigInteger.Parse(FirstLine[0]);
                var Price = BigInteger.Parse(FirstLine[1]);
                var Result = MoneyGiven - Price;
                Console.WriteLine(Result);
                Console.ReadKey();
            }
            catch (OverflowException)
            {
            }
        }
    }
}