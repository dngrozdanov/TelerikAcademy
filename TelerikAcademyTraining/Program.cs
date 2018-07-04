using System;
using System.Linq;

namespace BalancedNumbers
{
    static class Program
    {
        static void Main()
        {
            var Sum = 0;
            while (true)
            {
                var numInts = Console.ReadLine()?.Select(t => int.Parse(t.ToString()))
                    .ToArray();
                if (numInts == null) return;
                if (numInts[0] + numInts[2] == numInts[1])
                    Sum += int.Parse(string.Join("", numInts));
                else if (numInts[0] + numInts[2] != numInts[1])
                    break;
            }
            Console.Write(Sum);
        }
    }
}