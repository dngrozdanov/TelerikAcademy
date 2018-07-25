using System;
using SchoolOOP.Humans;

namespace SchoolOOP.Contracts
{
    public interface IStudent
    {
        int Grade { get; set; }
        int ClassNumber { get; set; }
    }
}
