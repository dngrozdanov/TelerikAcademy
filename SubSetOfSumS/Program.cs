using System;
using System.Linq;

namespace SubSetOfSumS
{
    class Program
    {
        static void Main()
        {
            int totalSum = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sums = new bool[totalSum + 1];
            sums[0] = true;
            foreach (var num in numbers)
            {
                for (int i = totalSum; i >= 0; i--)
                {
                    if (!sums[i])
                        continue;
                    if (i + num > totalSum)
                        continue;

                    sums[i + num] = true;
                }
            }

            if (sums[totalSum])
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}