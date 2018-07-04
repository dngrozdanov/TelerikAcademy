using System;

namespace CalculateProblem
{
    class Program
    {
        static void Main()
        {
            float N = Convert.ToSingle(Console.ReadLine());
            float x = Convert.ToSingle(Console.ReadLine());
            if (N < 2 || N > 10) return;
            if (x < 0.5f || x > 100) return;
            var Factorials = CalculateFactorial(new float[] {N, x});
            var Sum = Calculate(Factorials[0], Factorials[1], N, x);
            Console.WriteLine(Sum);
        }

        static float[] CalculateFactorial(float[] Nx)
        {
            float firstFactorial = 1;
            float secondFactorial = 1;
            for (int i = 1; i <= Math.Max(Nx[0], Nx[1]); i++)
            {
                if (i <= Nx[0])
                {
                    firstFactorial = firstFactorial * i;
                }
                if (i <= Nx[1])
                {
                    secondFactorial = secondFactorial * i;
                }
            }
            return new float[] { firstFactorial, secondFactorial };
        }

        static string Calculate(float NFactorial, float xFactorial, float N = 0, float x = 0)
        {
            double Sum;
            // S formula
            Sum = (1 + 1 / x + 2 / Math.Pow(x, 2)) + (NFactorial / Math.Pow(x, N));
            return Sum.ToString("0.00000");
        }
    }
}
