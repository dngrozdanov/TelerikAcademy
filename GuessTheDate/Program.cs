using System;

namespace GuessTheDate
{
    class Startup
    {
        static void Main()
        {
            int Year = int.Parse(Console.ReadLine());
            int Month = int.Parse(Console.ReadLine());
            int Day = int.Parse(Console.ReadLine());

            var toDateTime = new DateTime(Year, Month, Day).AddDays(-1).ToString("d-MMM-yyyy");
            Console.WriteLine($"{toDateTime}");
        }
    }
}