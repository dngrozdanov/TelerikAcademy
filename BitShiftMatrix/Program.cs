using System;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static BigInteger Sum;
        static int R, C, coef;
        static Vector2 currentPos;
        static BigInteger[,] Matrix;
        static void Main()
        {
            R = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            coef = Math.Max(R, C);
            int.Parse(Console.ReadLine());
            int[] Moves = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Matrix = new BigInteger[R, C];
            Matrix[R - 1, 0] = 1;
            currentPos.X = R - 1;

            for (int x = R - 1; x >= 0; x--)
            {
                for (int y = 0; y < C; y++)
                {
                    Matrix[x, y] = (BigInteger)Math.Pow(2, R - 1 - x + y);
                }
            }
            for (int s = 0; s < Moves.Length; s++)
            {
                var nextStep = GetNextStep(Moves[s]);
                // Column
                if ((int)currentPos.Y < nextStep[1])
                    for (int i = (int)currentPos.Y; i <= nextStep[1]; i++)
                    {
                        CollectSum(new Vector2(currentPos.X, i));
                        currentPos = new Vector2(currentPos.X, i);
                        }
                else if ((int)currentPos.Y > nextStep[1])
                    for (int i = (int)currentPos.Y; i >= nextStep[1]; i--)
                    {
                        CollectSum(new Vector2(currentPos.X, i));
                        currentPos = new Vector2(currentPos.X, i);
                    }
                // Row
                if ((int)currentPos.X < nextStep[0])
                    for (int i = (int)currentPos.X; i <= nextStep[0]; i++)
                    {
                        CollectSum(new Vector2(i, currentPos.Y));
                        currentPos = new Vector2(i, currentPos.Y);
                    }
                else if ((int)currentPos.X > nextStep[0])
                    for (int i = (int)currentPos.X; i >= nextStep[0]; i--)
                    {
                        CollectSum(new Vector2(i, currentPos.Y));
                        currentPos = new Vector2(i, currentPos.Y);
                    }
            }
            Console.WriteLine(Sum);
        }

        static void CollectSum(Vector2 vector)
        {
            Sum += Matrix[(int)vector.X, (int)vector.Y];
            Matrix[(int)vector.X, (int)vector.Y] = 0;
        }

        static int[] GetNextStep(int CODE)
        {
            return new int[] { CODE / coef, CODE % coef};
        }
    }
}