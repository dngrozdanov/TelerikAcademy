using System;
using System.Numerics;
using System.Linq;

namespace Bounce
{
    class Program
    {
        static BigInteger Sum = 1;
        static BigInteger[,] Matrix;
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int R = input[0];
            int C = input[1];
            Matrix = new BigInteger[R, C];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = (BigInteger)Math.Pow(2, i + j);
                }
            }

            int row = 0, col = 0;
            string direction = "downright";

            while(!(row == 0 && col == C - 1) && !(row == R - 1 && col == 0) && !(row == R - 1 && col == C - 1))
            {
                if (direction == "downright" && (col == C - 1))
                {
                    direction = "downleft";
                }
                else if (direction == "downright" && (row == R - 1))
                {
                    direction = "upright";
                }

                if (direction == "upright" && (col == C - 1))
                {
                    direction = "upleft";
                }
                else if (direction == "upright" && (row == 0))
                {
                    direction = "downright";
                }

                if (direction == "upleft" && (col == 0))
                {
                    direction = "upright";
                }
                else if (direction == "upleft" && (row == 0))
                {
                    direction = "downleft";
                }

                if (direction == "downleft" && (col == 0))
                {
                    direction = "downright";
                }
                else if (direction == "downleft" && (row == R - 1))
                {
                    direction = "upleft";
                }

                if (direction == "downright")
                {
                    row++;
                    col++;
                }
                if (direction == "downleft")
                {
                    row++;
                    col--;
                }
                if (direction == "upright")
                {
                    row--;
                    col++;
                }
                if (direction == "upleft")
                {
                    row--;
                    col--;
                }

                CollectSum(new Vector2(row, col));
                //Console.WriteLine($"Position: {row} {col} {Sum}");
            }
            Console.WriteLine(Sum);
        }

        static void CollectSum(Vector2 vector)
        {
            Sum += Matrix[(int)vector.X, (int)vector.Y];
        }
    }
}