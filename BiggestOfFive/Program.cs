using System;
using System.Linq;

namespace BiggestOfFive
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double[] doubleArray = { a, b, c, d, e };
            double finalMax = doubleArray.Max();
            if (finalMax == (int)finalMax)
            {
                Console.WriteLine((int)finalMax);
            }
            else
            {
                Console.WriteLine(finalMax);
            }
        }
    }
}