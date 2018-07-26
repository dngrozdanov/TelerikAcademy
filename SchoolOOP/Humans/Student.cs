using System;
using SchoolOOP.Contracts;

namespace SchoolOOP.Humans
{
    public class Student : Human, IStudent
    {
        private string comment;
        private int grade;
        private int classnumber;

        public int Grade { get { return this.grade; } set { if (value <= 0) throw new ArgumentOutOfRangeException("Grade cannot be less than or equal to zero."); this.grade = value; } }
        public int ClassNumber { get { return this.classnumber; } set { if (value <= 0) throw new ArgumentOutOfRangeException("Class Number cannot be less than or equal to zero."); this.classnumber = value; } }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (value.Length < 5 || value.Length > 100)
                    throw new ArgumentOutOfRangeException("Comment length cannot be less than 5 or more than 100 characters.");

                comment = value;
            }
        }

        public Student(string firstName, string lastName, int grade, int classnumber) : base(firstName, lastName)
        {
            this.Grade = grade;
            this.ClassNumber = classnumber;
        }
    }
}
