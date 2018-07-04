using System;
using System.Linq;

namespace ElMessage
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()?.ToArray();
            int currentcount = 0, max = 0;
            for (int i = 0; i < input?.Length; i++)
            {
                if (!(input[i] >= 'A' && input[i] <= 'Z') && !(input[i] >= 'a' && input[i] <= 'z') &&
                    !(input[i] >= '0' && input[i] <= '9') && input[i] != ' ' && input[i] != '.')
                {
                    currentcount++;
                }
                else
                {
                    if (currentcount > max) max = currentcount;
                    currentcount = 0;
                }
            }
            if (currentcount >= max) max = currentcount;

            Console.WriteLine(max);
        }
    }
}