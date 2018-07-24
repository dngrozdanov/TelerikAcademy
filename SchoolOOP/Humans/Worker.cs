using System;
namespace SchoolOOP.Humans
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Week Salary cannot be less than 0");

                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Work Hours Per Day cannot be less than 0");

                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, int weeksalary, int workhoursperday) : base(firstName, lastName)
        {
            this.WeekSalary = weeksalary;
            this.WorkHoursPerDay = workhoursperday;
        }

        public int MoneyPerHour()
        {
            return (WeekSalary / 7) * WorkHoursPerDay;
        }
    }
}
