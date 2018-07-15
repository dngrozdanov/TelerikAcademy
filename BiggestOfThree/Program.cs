using System;

namespace BiggestOfThree
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double finalMax = Math.Max(Math.Max(a, b), c);
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