using System;

namespace nFactorial
{
    class Program
    {
        static void Main()
        {
            int Factorial = int.Parse(Console.ReadLine());
            if (Factorial < 0 || Factorial > 100) return;
            Console.WriteLine(CalculateSingleFactorial(Factorial));
        }

        static int CalculateSingleFactorial(int Factorial)
        {
            int singleFactorial = 1;
            for (int i = 1; i <= Factorial; i++)
            {
                singleFactorial = singleFactorial * i;
            }
            return singleFactorial;
        }
    }
}