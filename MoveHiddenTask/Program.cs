using System;
using System.Linq;
using System.Collections.Generic;

namespace MoveHiddenTask
{
    class Program
    {
        static int ForwardSum = 0, BackwardSum = 0;
        static void Main()
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int[] arrayNumbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            string[] stepsDirectionSize = new string[3];
            Dictionary<int, Tuple<int, string, int>> stepsDirection = new Dictionary<int, Tuple<int, string, int>>();
            int dictionaryIndex = 0;
            while (stepsDirectionSize[0] != "exit")
            {
                stepsDirectionSize = Console.ReadLine().Split().ToArray();
                if (stepsDirectionSize[0] == "exit") break;
                stepsDirection.Add(dictionaryIndex, new Tuple<int, string, int>(int.Parse(stepsDirectionSize[0]), stepsDirectionSize[1], int.Parse(stepsDirectionSize[2])));
                dictionaryIndex++;
            }
            int currentPosition = startingPoint;
            foreach (var step in stepsDirection)
            {
                if (step.Value.Item2 == "forward")
                {
                    for (int i = 1; i <= step.Value.Item1; i++)
                    {
                        currentPosition = FindPosition(arrayNumbers, currentPosition, step.Value.Item3);
                        CollectSum(arrayNumbers, currentPosition, true);
                    }
                }
                else
                {
                    for (int i = 1; i <= step.Value.Item1; i++)
                    {
                        currentPosition = FindPosition(arrayNumbers, currentPosition, -step.Value.Item3);
                        CollectSum(arrayNumbers, currentPosition, false);
                    }
                }
            }
            Console.WriteLine($"Forward: {ForwardSum}{Environment.NewLine}Backwards: {BackwardSum}");
        }

        static void CollectSum(int[] array, int arrayPosition, bool isForward)
        {
            if (isForward)
                ForwardSum += array[arrayPosition];
            else
                BackwardSum += array[arrayPosition];
        }

        static int FindPosition(int[] array, int currentPosition, int step)
        {
            int Position = 0;
            Position = (currentPosition + step) % array.Length;
            if (Position < 0)
                Position += array.Length;
            return Position;
        }
    }
}