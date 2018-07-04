using System;
using System.Linq;

namespace MaxSumKElements
{
    internal static class Program
    {
        private static void Main()
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var K = Convert.ToInt32(Console.ReadLine());
            if (N < 1 || N > 1024) return;
            if (K < 1 || K > N) return;
            var ArrayNumbers = new int[N];
            for (var i = 0; i < N; i++)
                ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            var ArrayNumbersK = new int[K];
            var Highest = ArrayNumbers.OrderByDescending(i1 => i1).ToArray();
            for (var i = 0; i < K; i++)
                ArrayNumbersK[i] = Highest[i];
            var Result = 0;
            foreach (var num in ArrayNumbersK)
                Result += num;
            Console.WriteLine(Result);
        }
    }
}