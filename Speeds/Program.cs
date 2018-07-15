using System;
using System.Collections.Generic;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int Cars = int.Parse(Console.ReadLine());
            int groupSpeed = int.Parse(Console.ReadLine()), groupLength = 1, groupSum = groupSpeed, bestLength = 1, bestSum = groupSpeed;
            for (int i = 0; i < Cars - 1; i++)
            {
                int speed = int.Parse(Console.ReadLine());

                if (groupSpeed < speed)
                {
                    groupLength++;
                    groupSum += speed;
                }
                else
                {
                    groupSpeed = speed;
                    groupSum = speed;
                    groupLength = 1;
                }
                if (bestLength < groupLength)
                {
                    bestLength = groupLength;
                    bestSum = groupSum;
                }
                else if (bestLength == groupLength)
                {
                    bestSum = Math.Max(bestSum, groupSum);
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}