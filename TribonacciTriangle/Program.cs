using System;

namespace TribonacciTriangle
{
    class Program
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            long t;

            for (int i = 1; i <= L; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(firstNumber);
                }
                else if (i == 2)
                {
                    Console.WriteLine("{0} {1}", secondNumber, thirdNumber);
                }
                else if (i > 2)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        t = firstNumber + secondNumber + thirdNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = t;
                        if (j < i)
                        {
                            Console.Write("{0} ", t);
                        }
                        else if (j == i)
                        {
                            Console.Write(t);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}