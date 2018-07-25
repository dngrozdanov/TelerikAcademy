using System;
using SchoolOOP.Contracts;

namespace SchoolOOP.Humans
{
    public class Student : Human, IStudent
    {
        private int grade;
        private int classnumber;

        public int Grade { get { return this.grade; } set { if (value <= 0) throw new ArgumentOutOfRangeException("Grade cannot be less than or equal to zero."); this.grade = value; } }
        public int ClassNumber { get { return this.classnumber; } set { if (value <= 0) throw new ArgumentOutOfRangeException("Class number cannot be less than or equal to zero."); this.classnumber = value; } }

        public Student(string firstName, string lastName, int grade, int classnumber) : base(firstName, lastName)
        {
            this.Grade = grade;
            this.ClassNumber = classnumber;
        }
    }
}
