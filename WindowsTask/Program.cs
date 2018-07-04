using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsTask
{
    class Program
    {
        static Dictionary<int, Tuple<int, int, int>> WindowsDictionary { get; set; } = new Dictionary<int, Tuple<int, int, int>>();
        static void Main()
        {
            // Task: Don't finish the task by doing it the easy way
            int n = 0, c = 0;

            var firstLine = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            n = firstLine[0];
            c = firstLine[1];

            for (int i = 0; i < n; i++)
            {
                int width = 0, height = 0, broken = 0;

                var tempLine = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                width = tempLine[0];
                height = tempLine[1];
                broken = tempLine[2];

                WindowsDictionary.Add(i, new Tuple<int, int, int>(width, height, broken));
            }
            int TotalRepairSum = 0;
            foreach (var brokenwindow in WindowsDictionary.Where(x => x.Value.Item3 == 0))
            {
                TotalRepairSum += brokenwindow.Value.Item1 * brokenwindow.Value.Item2;
            }
            Console.WriteLine(TotalRepairSum);
        }
    }
}
