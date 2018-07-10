using System;

namespace ForestRoad
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int left = 0, right = N - 1;
            int size = 2 * N - 1;
            for (int i = 0; i < size; i++)
            {
                if (i < size / 2)
                {
                    Console.WriteLine(new string('.', left) + "*" + new string('.', right));
                    left++;
                    right--;
                }
                else
                {
                    Console.WriteLine(new string('.', left) + "*" + new string('.', right));
                    --left;
                    ++right;
                }
            }
        }
    }
}