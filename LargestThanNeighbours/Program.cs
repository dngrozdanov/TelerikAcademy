using System;
using System.Linq;

namespace LargestThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (i - 1 >= 0 && i + 1 < arraySize)
                    if (arrayNumbers[i] > arrayNumbers[i - 1] && arrayNumbers[i] > arrayNumbers[i + 1])
                        count++;
            }
            Console.WriteLine(count);
        }
    }
}