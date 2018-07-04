using System;

namespace IntDoubleString
{
    internal static class Program
    {
        internal static void Main()
        {
            var Type = Console.ReadLine();
            switch (Type)
            {
                case "integer":
                    var Integer = Convert.ToInt32(Console.ReadLine());
                    if (Integer < -1000 || Integer > 1000) return;
                    Console.WriteLine(Integer + 1);
                    break;
                case "real":
                    var DInteger = Convert.ToDouble(Console.ReadLine());
                    if (DInteger < -1000 || DInteger > 1000) return;
                    Console.WriteLine((DInteger + 1).ToString("0.00"));
                    break;
                case "text":
                    var text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}