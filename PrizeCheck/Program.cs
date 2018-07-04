using System;
using System.Linq;

namespace PrizeCheck
{
    internal static class Program
    {
        private static void Main()
        {
            var NonConvertedNumbers = Console.ReadLine()?.Split();
            if (NonConvertedNumbers?.Length != 7) return;
            if (NonConvertedNumbers.Any(x => x != null && Convert.ToInt32(x) > 6)) return;
            if (NonConvertedNumbers.Any(x => x != null && Convert.ToInt32(x) < 2)) return;
            if (NonConvertedNumbers.Contains("2"))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var Six in NonConvertedNumbers.Where(x => x.Contains("6")))
                    Console.Write("*");
                Console.ReadKey();
            }
        }
    }
}