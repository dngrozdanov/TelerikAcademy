using System;

namespace CalculateProblem
{
    class Program
    {
        static void Main()
        {
            long N = Convert.ToInt32(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());

            long tempFact = 1;
            double Sum = 1;
            for (int i = 1; i <= N; i++)
            {
                tempFact = tempFact * i;
                Sum += tempFact / Math.Pow(x, i);
            }
            Console.WriteLine(string.Format("{0:F5}", Sum));
        }
    }
}
