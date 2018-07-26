using System;
using SchoolOOP.Contracts;
using System.Collections.Generic;
using System.Collections;
namespace SchoolOOP.Humans
{
    public class Teacher : Human, ITeacher
    {
        private string comment;
        private IList<IDiscipline> disciplines;
        public IList<IDiscipline> Disciplines
        {
            get
            {
                return new List<IDiscipline>(disciplines);
            }
            set
            {
                this.disciplines = value;
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

        public Teacher(string firstname, string lastname) : base(firstname, lastname)
        {

        }

        public void AddDiscipline(IDiscipline discipline)
        {
            if (!this.disciplines.Contains(discipline))
                this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(IDiscipline discipline)
        {
            if (this.disciplines.Contains(discipline))
                this.disciplines.Remove(discipline);
        }
    }
}
