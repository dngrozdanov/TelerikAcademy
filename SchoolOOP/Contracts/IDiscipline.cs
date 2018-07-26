using System;
namespace SchoolOOP.Contracts
{
    public interface IDiscipline : IComment
    {
        string Name { get; set; }
        int NumberOfLectures { get; set; }
        int NumberOfExercises { get; set; }
    }
}