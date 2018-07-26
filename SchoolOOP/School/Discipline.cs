using System;
using SchoolOOP.Contracts;
namespace SchoolOOP
{
    public class Discipline : IDiscipline
    {
        private string name;
        private string comment;
        private int numberoflectures;
        private int numberofexercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentOutOfRangeException("Name length cannot be less than 3 or more than 15 characters.");

                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberoflectures;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Number of Lectures cannot be negative number.");

                this.numberoflectures = value;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberofexercises;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Number of Exercises cannot be negative number.");

                this.numberofexercises = value;
            }
        }

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

        public Discipline(string name, int numberoflectures, int numberofexercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberoflectures;
            this.NumberOfExercises = numberofexercises;
        }
    }
}
