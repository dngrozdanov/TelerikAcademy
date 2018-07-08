using System;

class Program
{
    static void Main()
    {
        short N = short.Parse(Console.ReadLine());
        for (short i = 1; i <= N; i++)
        {
            Console.Write(i + " ");
        }
    }
}