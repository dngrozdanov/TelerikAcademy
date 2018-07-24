using System;
using SchoolOOP.Enumerators;

namespace SchoolOOP.Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 12)
                    throw new ArgumentOutOfRangeException("Name length cannot be less than 3 or more than 12 characters.");

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age cannot be negative number.");

                this.age = value;
            }
        }

        public Sex Sex { get; set; }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
