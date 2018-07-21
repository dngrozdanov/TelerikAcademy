using System;
namespace PhoneOOP
{
    public class Call
    {
        public DateTime DateTime { get; set; }
        public int PhoneNumber { get; set; }
        public int Duration { get; set; }

        public Call(DateTime date, int number, int duration)
        {
            this.DateTime = date;
            this.PhoneNumber = number;
            this.Duration = duration;
        }
    }
}