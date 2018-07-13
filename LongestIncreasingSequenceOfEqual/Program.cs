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
            int currentNum = 0, maxIncrease = 0;
            foreach (var num in Numbers)
            {
                if (num > currentNum)
                {
                    currentNum = num;
                    maxIncrease++;
                }
                else
                {
                    currentNum = num;
                    maxIncrease = 0;
                }
            }
        }
    }
}
