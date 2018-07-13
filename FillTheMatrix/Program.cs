using System;

namespace FillTheMatrix
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string Way = Console.ReadLine();
            switch (Way)
            {
                case "a":
                    FillMatrixA(N);
                    break;
                case "b":
                    FillMatrixB(N);
                    break;
                case "c":
                    FillMatrixC(N);
                    break;
                case "d":
                    FillMatrixD(N);
                    break;
            }
        }

        static void FillMatrixA(int N)
        {
            int row = 0, col = 0;
            int[,] Matrix = new int[N, N];

            for (int i = 1; i <= N * N; i++)
            {
                if (row > N - 1)
                {
                    row = 0;
                    col++;
                }
                Matrix[row, col] = i;
                row++;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write("{0,4}", Matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        static void FillMatrixB(int N)
        {
            int row = 0, col = 0;
            int[,] Matrix = new int[N, N];
            string direction = "down";

            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "down" && row > N - 1)
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && row < 0)
                {
                    direction = "down";
                    row++;
                    col++;
                }

                Matrix[row, col] = i;

                if (direction == "down")
                    row++;
                if (direction == "up")
                    row--;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write("{0,4}", Matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        // Unfinished
        static void FillMatrixC(int N)
        {
            int[,] Matrix = new int[N, N];
            Matrix[N - 1, 0] = 1;
            for (int x = N - 1; x >= 0; x--)
            {
                for (int y = 0; y < N; y++)
                {
                    Matrix[x, y] = (int)Math.Pow(2, N - 1 - x + y);
                }
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write("{0,4}", Matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        static void FillMatrixD(int N)
        {
            int row = 0, col = 0;
            int[,] Matrix = new int[N, N];
            string direction = "down";

            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "down" && (row > N - 1 || Matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }
                if (direction == "right" && (col > N - 1 || Matrix[row, col] != 0))
                {
                    direction = "up";
                    row--;
                    col--;
                }
                if (direction == "up" && (row < 0 || Matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }
                if (direction == "left" && (col < 0 || Matrix[row, col] != 0))
                {
                    direction = "down";
                    row++;
                    col++;
                }

                Matrix[row, col] = i;

                if (direction == "down")
                    row++;
                if (direction == "right")
                    col++;
                if (direction == "up")
                    row--;
                if (direction == "left")
                    col--;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    Console.Write("{0,4}", Matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
