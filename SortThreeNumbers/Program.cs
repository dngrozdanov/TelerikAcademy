using System;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
    
            if (first < second)
                Swap(ref first, ref second);
            if (second < third)
                Swap(ref second, ref third);
            if (first < second)
                Swap(ref first, ref second);
    
            Console.WriteLine($"{first} {second} {third}");
        }
    
        static void Swap(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
    }
}