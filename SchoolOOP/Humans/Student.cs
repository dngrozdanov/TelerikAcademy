using System;
namespace SchoolOOP.Humans
{
    public class Student : Human
    {
        private int grade;
        public int Grade { get { return this.grade; } set { if (value <= 0) throw new ArgumentOutOfRangeException("Grade cannot be less than or equal to zero."); this.grade = value; } }
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
