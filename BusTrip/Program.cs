using System;
using System.Linq;

namespace BusTrip
{
    class Program
    {
        private static int Crash, CrashObstacleIndex;
        private static void Main()
        {
            int[] BusSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int BusWidth = BusSize[0];
            int BusHeight = BusSize[1];
            int Obstacles = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Obstacles; i++)
            {
                int[] TempArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if ((TempArray[0] < BusWidth || TempArray[1] < BusHeight) && Crash == 0)
                {
                    CrashObstacleIndex = i;
                    Crash = 1;
                }
            }
            // Print whether or not the bus will crash and where during the course
            if (Crash == 0)
            {
                Console.WriteLine("No crash");
            }
            else if (Crash != 0)
            {
                Console.WriteLine(CrashObstacleIndex + 1);
            }
        }
    }
}