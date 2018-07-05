using System;

namespace AboveTheMainDiagonal
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    long temp = (long)Math.Pow(2, i + j);
                    if (j >= i)
                        sum += temp;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
