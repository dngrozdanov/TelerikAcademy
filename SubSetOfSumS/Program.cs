using System;

namespace SubSetOfSumS
{
    class Program
    {
        static void Main()
        {
            int Sum = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int[] IntArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                IntArray[i] = int.Parse(input[i]);
            }

            long currentSum = 0;
            int count = 0;

            for (int i = 1; i <= (int)Math.Pow(2, IntArray.Length) - 1; i++)
            {
                currentSum = 0;
                string temp = Convert.ToString(i, 2).PadLeft(IntArray.Length, '0');

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j].ToString() == "1")
                    {
                        currentSum += IntArray[j];
                    }
                }

                if (currentSum == Sum)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}