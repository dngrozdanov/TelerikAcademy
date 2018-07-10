using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[N, N];
            int row = 0, col = 0;
            string direction = "right";

            // Loop цикъл, от 1 до N * N включително
            for (int i = 1; i <= N * N; i++)
            {
                // Ако излиза от матрицата надясно, промени посоката надолу
                // И дръпни една колона назад за да влезе обратно в матрицата
                if (direction == "right" && (col > N - 1 || Matrix[row, col] != 0))
                {
                    direction = "down";
                    row++;
                    col--;
                }
                // Ако излиза от матрицата надолу, промени посоката наляво
                // И дръпни една колона наляво и един ред нагоре
                if (direction == "down" && (row > N - 1 || Matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                // Ако излиза от матрицата наляво, промени посоката нагоре
                // И дръпни един ред нагоре и бутни един ред напред за да влезем в матрицата обратно
                if (direction == "left" && (col < 0 || Matrix[row, col] != 0))
                {
                    direction = "up";
                    row--;
                    col++;
                }
                // Ако излиза от матрицата нагоре, промени посоката надясно
                // И бутни с един ред надолу за да влезем обратно в матрицата + една колона надясно
                if (direction == "up" && (row < 0 || Matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                // Актуализираме позицията ни в матрицата
                Matrix[row, col] = i;

                // Бутане,Дърпане с един ред/колона в зависимост от посоката
                if (direction == "right")
                    col++;
                if (direction == "down")
                    row++;
                if (direction == "left")
                    col--;
                if (direction == "up")
                    row--;
            }

            // Принтиране на матрицата
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    Console.Write("{0,4}", Matrix[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}