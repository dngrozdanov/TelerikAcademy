using System;
namespace SchoolOOP.Humans
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == "")
                    throw new ArgumentNullException("First Name cannot be empty.");

                this.FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == "")
                    throw new ArgumentNullException("Last Name cannot be empty.");

                this.lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}