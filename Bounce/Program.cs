using System;
using System.Numerics;
using System.Linq;

namespace Bounce
{
    class Program
    {
        static BigInteger Sum;
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

            // Loop цикъл, от 1 до R * C включително
            while(true)
            {
                if (direction == "downright" && (col > C - 1))
                {
                    direction = "downleft";
                    row++;
                    col--;
                }
                else if (direction == "downright" && (row > R - 1))
                {
                    direction = "upright";
                    row--;
                    col++;
                }

                if (direction == "upright" && (col > C - 1))
                {
                    direction = "upleft";
                    row--;
                    col--;
                }
                else if (direction == "upright" && (row < 0))
                {
                    direction = "downright";
                    row++;
                    col++;
                }

                if (direction == "upleft" && (col < 0))
                {
                    direction = "upright";
                    //row--;
                    col += 2;
                }
                else if (direction == "upleft" && (row < 0))
                {
                    direction = "downleft";
                    row += 2;
                    //col--;
                }

                if (direction == "downleft" && (col < 0))
                {
                    direction = "downright";
                    row++;
                    col++;
                }
                else if (direction == "downleft" && (row > R - 1))
                {
                    direction = "upleft";
                    row--;
                    col--;
                }

                if (direction == "downleft" && row == R - 1 && col == 0)
                {
                    CollectSum(new Vector2(row, col));
                    break;
                }
                else if (direction == "downright" && row == R - 1 && col == C - 1)
                {
                    CollectSum(new Vector2(row, col));
                    break;
                }
                else if (direction == "upleft" && row == 0 && col == 0)
                {
                    CollectSum(new Vector2(row, col));
                    break;
                }
                else if (direction == "upright" && row == 0 && col == C - 1)
                {
                    CollectSum(new Vector2(row, col));
                    break;
                }
                else
                    CollectSum(new Vector2(row, col));
                //Console.WriteLine($"Position: {row} {col} {Sum}");

                // Бутане,Дърпане с един ред/колона в зависимост от посоката
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
            }
            Console.WriteLine(Sum);
        }

        static void CollectSum(Vector2 vector)
        {
            Sum += Matrix[(int)vector.X, (int)vector.Y];
            //Matrix[(int)vector.X, (int)vector.Y] = 0;
        }
    }
}