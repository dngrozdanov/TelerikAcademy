using System;
using SchoolOOP.Humans;

namespace SchoolOOP.Contracts
{
    public interface IStudent : IComment
    {
        int Grade { get; set; }
        int ClassNumber { get; set; }
    }
}