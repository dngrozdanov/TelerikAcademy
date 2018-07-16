using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HIDDENTASK_JOROTHENAUGHTY
{
    class Program
    {
        static BigInteger Sum = 0, JumpsDone = 0;
        static int[,] Matrix;
        static void Main()
        {
            try
            {
                int[] RowsColsJumps = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                int row = RowsColsJumps[0];
                int col = RowsColsJumps[1];
                int[] StartPositionXY = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                Dictionary<int, Tuple<int, int>> Jumps = new Dictionary<int, Tuple<int, int>>();
                for (int i = 0; i < RowsColsJumps[2]; i++)
                {
                    int[] XY = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                    Jumps.Add(i, new Tuple<int, int>(XY[0], XY[1]));
                }
                Matrix = new int[row, col];

                int indexNum = 1;
                for (int i = 0; i < row; i++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Matrix[i, y] = indexNum;
                        indexNum++;
                    }
                }

                int[] currentPosition = { StartPositionXY[0], StartPositionXY[1] };
                CollectSum(currentPosition);

                while (true)
                {
                    for (int i = 0; i < Jumps.Count; i++)
                    {
                        var tempJump = Jumps[i];
                        currentPosition[0] += tempJump.Item1;
                        currentPosition[1] += tempJump.Item2;
                        if (currentPosition[0] >= row || currentPosition[1] >= col || currentPosition[0] < 0 || currentPosition[1] < 0)
                        {
                            Console.WriteLine($"escaped {Sum}");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (Matrix[currentPosition[0], currentPosition[1]] == 0)
                            {
                                Console.WriteLine($"caught {JumpsDone}");
                                Environment.Exit(0);
                            }
                            CollectSum(currentPosition);
                            JumpsDone++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CollectSum(int[] position)
        {
            Sum += Matrix[position[0], position[1]];
            Matrix[position[0], position[1]] = 0;
        }
    }
}