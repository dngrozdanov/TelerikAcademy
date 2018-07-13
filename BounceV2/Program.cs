using System;
using System.Linq;

namespace BounceV2
{
    class Program
    {
        static void Main()
        {
            long[] size = Console.ReadLine().Split().Select(long.Parse).ToArray();
            size[0] = 1 - size[0];
            size[1] -= 1;
            long currentX = 0, currentY = 0, direction = 0, currentValue = 1, output = 1;
            while(true)
            {
                if (currentY == size[0] && currentX == size[1] || currentY == 0 && currentX == size[1] || currentY == size[0] && currentX == 0)
                {
                    Console.WriteLine(output);
                    return;
                }
                if (direction == 0)
                {
                    currentX++;
                    currentY--;

                    currentValue *= 4;
                    output += currentValue;

                    if (currentX == size[1]) direction = 3;
                    else if (currentY == size[0]) direction = 1;
                }
                else if (direction == 1)
                {
                    currentX++;
                    currentY++;

                    output += currentValue;

                    if (currentX == size[1]) direction = 2;
                    else if (currentY == 0) direction = 0;
                }
                else if (direction == 2)
                {
                    currentX--;
                    currentY++;
                    currentValue /= 4;
                    output += currentValue;
                    if (currentX == 0) direction = 1;
                    else if (currentY == 0) direction = 3;
                }
                else if (direction == 3)
                {
                    currentX--;
                    currentY--;
                    output += currentValue;
                    if (currentX == 0) direction = 0;
                    else if (currentY == size[0]) direction = 2;
                }
            }
        }
    }
}