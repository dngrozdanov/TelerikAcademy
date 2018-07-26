using System;
using System.Collections.Generic;

namespace SchoolOOP.Contracts
{
    public interface ITeacher : IComment
    {
        IList<Discipline> Disciplines { get; set; }
    }
}
