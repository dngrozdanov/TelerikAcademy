using System;
using System.Linq;

namespace MatrixSum3x3
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// Matrix [row, col] to solve
        static void Main()
        {
            int N = 0, M = 0, Sum = 0;

            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            N = firstLine[0];
            M = firstLine[1];

            for (int i = 0; i < N; i++)
            {
                int[] tempLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (tempLine.Length > M || tempLine.Length < M) return;
                if (i < 3)
                {
                    Sum += tempLine[0];
                    Sum += tempLine[1];
                    Sum += tempLine[2];
                }
            }

            Console.WriteLine(Sum);
        }
    }
}
