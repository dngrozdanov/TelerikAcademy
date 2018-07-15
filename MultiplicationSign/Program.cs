using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine());
            int d = 0;
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (a < 0)
                d++;
            if (b < 0)
                d++;
            if (c < 0)
                d++;
            if (d % 2 == 0)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");
        }
    }
}