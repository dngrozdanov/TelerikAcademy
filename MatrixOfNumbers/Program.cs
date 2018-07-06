using System;

namespace MatrixOfNumbers
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        static void Main()
        {
            // Solution: No Matrix Used
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(i + j + 1 + " ");
                }
                Console.WriteLine();
            }

            // Solution: No Matrix Used
            /*int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) // Row
            {
                for (int j = i; j < N + i; j++) // Column
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }*/

            /*int[,] matrix =
            {
                {1, 2},
                {3, 4}
            };

            // Solution: Matrix Used
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 2}", matrix[i, j]);
                }
                Console.WriteLine();
            }*/
        }
    }
}