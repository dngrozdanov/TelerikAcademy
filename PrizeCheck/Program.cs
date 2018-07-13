using System;
using System.Linq;

namespace PrizeCheck
{
    static class Program
    {
        static void Main()
        {
            var NonConvertedNumbers = Console.ReadLine().Split();
            if (NonConvertedNumbers.Contains("2") || !NonConvertedNumbers.Contains("6"))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var Six in NonConvertedNumbers.Where(x => x.Contains("6")))
                    Console.Write("*");
            }
        }
    }
}