using System;
using System.Linq;

namespace SubSetOfSumS
{
    internal class Program
    {
        private static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var Numbers = Console.ReadLine()?.Split().Select(int.Parse).ToArray();

            Quicksort(Numbers, 0, Numbers.Length - 1);
            var Sum = 0;

            for (var i = 0; i < Numbers.Length; i++)
                if (Sum + Numbers[i] <= N)
                {
                    if (Sum + Numbers[i] == N || Sum + Numbers[i+1] == N)
                    {
                        Console.WriteLine("yes");
                        break;
                    }
                    Sum += Numbers[i];
                }
                else if (Sum > N || Sum < N)
                {
                    Console.WriteLine("no");
                    break;
                }

            Console.ReadLine();
        }

        private static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                    i++;

                while (elements[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = (int) tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
                Quicksort(elements, left, j);

            if (i < right)
                Quicksort(elements, i, right);
        }
    }
}