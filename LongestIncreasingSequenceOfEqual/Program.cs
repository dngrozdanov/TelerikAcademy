using System;
using System.Collections.Generic;

namespace LongestIncreasingSequenceOfEqual
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> Numbers = new List<int>();
            for (int i = 0; i < N; i++)
            {
                Numbers.Add(int.Parse(Console.ReadLine()));
            }
            int prevNum = Numbers[0], maxIncrease = 1, currentIncrease = 1;
            foreach (var num in Numbers)
            {
                if (num > prevNum)
                {
                    currentIncrease++;
                }
                else
                {
                    currentIncrease = 1;
                }

                prevNum = num;
                maxIncrease = Math.Max(maxIncrease, currentIncrease);
            }
            Console.WriteLine(maxIncrease);
        }
    }
}