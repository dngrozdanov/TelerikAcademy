using System;
using System.Linq;

namespace SumFromNToM
{
    class Startup
    {
        static void Main()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = nm[0]; i <= nm[1]; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}