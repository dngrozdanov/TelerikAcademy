using System;
using System.Collections.Generic;

namespace SchoolOOP.Contracts
{
    public interface IClass : IComment
    {
        string ClassName { get; set; }
        IList<ITeacher> Teachers { get; set; }
    }
}
